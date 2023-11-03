namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculo de Fatorial, digite um número: ");
            int x = int.Parse(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= x; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine(fatorial);
        }
    }
}