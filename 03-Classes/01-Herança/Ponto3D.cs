namespace Classes.Herança
{
    public class Ponto3D : Ponto //Está herdando de ponto, NÃO EXISTE HERANÇA MÚLTIPLA
    {
        public int z;

        //:base serve para passar os parâmetros recebidos para a classe pai
        public Ponto3D(int x, int y, int z) : base(x, y) 
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular()
        {
            //Faz alguma coisa...
        }

        //override sobrescreve  o método da classe base
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }

        internal void MetodoInternal(){
            
        }
    }
}