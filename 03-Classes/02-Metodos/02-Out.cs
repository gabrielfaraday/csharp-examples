namespace Classes.Metodos
{
    public class Out
    {

        //O out define variáveis que serão preenchidas no método a ser chamado
        //Assim, o método que está requisitando conseguirá obter o valor das variáveis
        static void Dividir(int x, int y, out int resultado, out int resto) 
        {
            resultado = x / y;
            resto = x % y;
        }
        
        public static void Dividir() 
        {
            Dividir(10, 3, out int resultado, out int resto);
            System.Console.WriteLine("{0} {1}", resultado, resto);	// Escreve "3 1"
        }
    }
}