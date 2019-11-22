using System;

namespace Classes.Metodos
{
    public class RaizQuadrada
    {
        public static void Calcular()
        {
            int i = 0;
            int j;
            while (i < 10)
            {
                j = i * i;
                Console.WriteLine($"{i} x {i} = {j}");
                i = i + 1;
            }
        }
    }
}