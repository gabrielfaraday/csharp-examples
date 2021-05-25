namespace Classes.Metodos
{
    public class Ref
    {
        static void Inverter(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter()
        {
            int i = 1, j = 2;

            //Ao passar via ref, o método Inverter irá alterar os valores declarados nesse método;
            //Com o ref as funções apotam para o mesmo local da memória
            Inverter(ref i, ref j);

            //$"{var}": concatena string com variável
            System.Console.WriteLine($"{i} {j}");    // Escreve "2 1"
        }
    }
}