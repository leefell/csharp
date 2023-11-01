namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            if(n > 0)
            {
                Console.WriteLine("Não Negativo.");
            }
            else if(n < 0)
            {
                Console.WriteLine("Negativo.");
            }
            else
            {
                Console.WriteLine("Ñão Negativo (Zero)");
            }
        }
    }
}