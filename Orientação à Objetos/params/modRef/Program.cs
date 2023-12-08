namespace modRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //code smells (design ruim)
            Console.WriteLine("Por ref");
            int a = 10;
            Calculadora.TriplicarREF(ref a);
            Console.WriteLine(a);

            Console.WriteLine("\nPor out");
            int b = 10;
            int triplicar; // essa é a variavel nao inicializada
            Calculadora.TriplicarOUT(b, out triplicar);
            Console.WriteLine(triplicar);
        }
    }
}