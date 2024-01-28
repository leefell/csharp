namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}