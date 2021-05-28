using System;
using Classes.Herança;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando objetos
            Ponto p1 = new Ponto(10, 20);

            Ponto3D p2 = new Ponto3D(10, 20, 30);

            p2.MetodoInternal();
            int x = p1.x;
            
            Ponto3D.Calcular();//Método estático
            
        }
    }
}
