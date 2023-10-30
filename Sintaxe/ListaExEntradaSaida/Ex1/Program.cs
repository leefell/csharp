namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            float soma = n1 + n2;

            Console.WriteLine("A soma dos dois número é {0} ", soma);

        }
    }
}