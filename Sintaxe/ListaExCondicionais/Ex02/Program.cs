namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}