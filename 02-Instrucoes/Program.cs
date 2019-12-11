using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }

        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucaoDo(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                {
                    break;
                }

                Console.WriteLine(s);
            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }
                
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(string[] args)
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }

        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 números");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Até breve!");
            }
        }

        static void InstrucaoUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}
