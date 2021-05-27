using System;

namespace desafios
{
    class Program
    {
        static void Main(string[] args)
        {

            calculaNotasMoedas();

        }

        static void calculaNotasMoedas()
        {
            decimal valor;
            int inteiro, auxNotas, auxMoedas;

            var entrada = Console.ReadLine();
            valor = decimal.Parse(entrada);

            inteiro = (int)valor;


            auxMoedas = (int)((valor - inteiro) * 100);


            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", inteiro / 100);
            auxNotas = (inteiro % 100);

            Console.WriteLine("{0} nota(s) de R$ 50.00", auxNotas / 50);
            auxNotas = (auxNotas % 50);

            Console.WriteLine("{0} nota(s) de R$ 20.00", auxNotas / 20);
            auxNotas = (auxNotas % 20);

            Console.WriteLine("{0} nota(s) de R$ 10.00", auxNotas / 10);
            auxNotas = (auxNotas % 10);

            Console.WriteLine("{0} nota(s) de R$ 5.00", auxNotas / 5);
            auxNotas = (auxNotas % 5);

            Console.WriteLine("{0} nota(s) de R$ 2.00", auxNotas / 2);
            auxNotas = (auxNotas % 2);


            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", auxNotas / 1);


            Console.WriteLine("{0} moeda(s) de R$ 0.50", auxMoedas / 50);
            auxMoedas %= 50;

            Console.WriteLine("{0} moeda(s) de R$ 0.25", auxMoedas / 25);
            auxMoedas %= 25;

            Console.WriteLine("{0} moeda(s) de R$ 0.10", auxMoedas / 10);
            auxMoedas %= 10;

            Console.WriteLine("{0} moeda(s) de R$ 0.05", auxMoedas / 5);
            auxMoedas %= 5;

            Console.WriteLine("{0} moeda(s) de R$ 0.01", auxMoedas / 1);
        }

        static void calculaCombustivelMedio()
        {
            int distancia;

            double combustivelGasto, consumoMedio;

            distancia = Convert.ToInt32(Console.ReadLine());

            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = distancia / combustivelGasto;
            Console.WriteLine("{0:0.000} km/l", consumoMedio);
        }

        public static void verificaDDD()
        {
            int ddd = Convert.ToInt32(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                    Console.WriteLine("Brasilia");
                    break;
                case 71:                             //complete os DDD's corretamente
                    Console.WriteLine("Salvador");
                    break;
                case 11:
                    Console.WriteLine("Sao Paulo");
                    break;
                case 21:
                    Console.WriteLine("Rio de Janeiro");
                    break;
                case 32:
                    Console.WriteLine("Juiz de Fora");
                    break;
                case 19:
                    Console.WriteLine("Campinas");
                    break;
                case 27:
                    Console.WriteLine("Vitoria");
                    break;
                case 31:
                    Console.WriteLine("Belo Horizonte");
                    break;
                default:
                    Console.WriteLine("DDD nao cadastrado");
                    break;
            }
        }
    }
}
