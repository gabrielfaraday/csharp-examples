namespace Classes.Herança
{
    public class Ponto
    {
        /*public: membro acessível a qualquer classe do projeto
            private: membro acessível somente dentro da classe
            protected: somente classes que herdam têm acesso
            internal: o acesso é limitado ao assembly atual
        */
        public int x, y;
        private int distancia;
        
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //Faz alguma coisa...
            CalcularDistancia2();
        }

        private void CalcularDistancia2()
        {
            //Faz alguma coisa...
        }

        //virtual permite sobrescrever o método
        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa...
        }
    }
}