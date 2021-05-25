using System;

namespace Revisao
{
    class Program
    {
        protected static Aluno[] alunos = new Aluno[5];  //Instanciando 5 alunos
        protected static int indiceAluno = 0;

        public static Boolean cadastraAluno()
        {
            if (indiceAluno == 5)
            {
                Console.WriteLine("Impossível adicionar mais alunos");
                return false;
            }
            Console.WriteLine("Informe o nome do aluno:");

            var nome = Console.ReadLine();

            //Verifica se realmente foi digitado um nome
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("O nome do aluno não pode ser vazio! - Tente novamente");
                return false;
            }

            var aluno = new Aluno();
            aluno.Nome = nome;

            Console.WriteLine("Informe a nota do aluno:");

            //Já preenche a nota com o console.ReadLine
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
                //throw new ArgumentException("Valor da nota deve ser decimal");
                Console.WriteLine("Valor da nota deve ser decimal - Tente novamente");
                return false;
            }

            alunos[indiceAluno] = aluno;
            indiceAluno++;

            return true;
        }

        static void listaAlunos()
        {

             if(string.IsNullOrEmpty(alunos[0].Nome)){
                    Console.WriteLine("Nenhum aluno encontrado!");
                    return;
            }
            
            foreach (var aluno in alunos)
            {
                if (!string.IsNullOrEmpty(aluno.Nome))
                {
                    Console.WriteLine($"ALUNO: {aluno.Nome} - NOTA: {aluno.Nota}");
                }
            }
        }

        static void calculaMedia()
        {
            decimal notaTotal = 0;
            var nrAlunos = 0; //Vai precisar dessa var porque o número de alunos é 5, mas pode ter menos de 5 alunos cadastrados

            //Verifica se a primeira posição está preenchida
            if(string.IsNullOrEmpty(alunos[0].Nome)){
                    Console.WriteLine("Nenhum aluno encontrado!");
                    return;
            }

            for (int i = 0; i < alunos.Length; i++)
            {
                if (!string.IsNullOrEmpty(alunos[i].Nome))
                {
                    notaTotal += alunos[i].Nota;
                    nrAlunos++;
                }
            }

            var mediaGeral = notaTotal / nrAlunos;
            Conceito conceitoGeral;

            if (mediaGeral < 2)
            {
                conceitoGeral = Conceito.E;
            }
            else if (mediaGeral < 4)
            {
                conceitoGeral = Conceito.D;
            }
            else if (mediaGeral < 6)
            {
                conceitoGeral = Conceito.C;
            }
            else if (mediaGeral < 8)
            {
                conceitoGeral = Conceito.B;
            }
            else
            {
                conceitoGeral = Conceito.A;
            }

            Console.WriteLine($"MÉDIA GERAL: {mediaGeral} - CONCEITO: {conceitoGeral}");
        }
        static void Main(string[] args)
        {
            //O var permite tipagem dinâmica

            string opcaoUsuario = ObterOpcaoUsuario();

            //ToUpper conver para uppercase
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        if (cadastraAluno())
                        {
                            Console.WriteLine("Aluno cadastrado com sucesso!");
                        }
                        break;
                    case "2":
                        listaAlunos();
                        break;
                    case "3":
                        calculaMedia();
                        break;
                    default:
                        throw new ArgumentException("Opção Inválida!");
                }
                opcaoUsuario = ObterOpcaoUsuario();
            } 
            Console.Write("Até mais!\n\n");
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("\nInforme a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair \n");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
