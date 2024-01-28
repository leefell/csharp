namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os 4 valores por espaço: ");
            string[] array = Console.ReadLine().Split(' ');

            int n1 = int.Parse(array[0]);
            int n2 = int.Parse(array[1]);
            int n3 = int.Parse(array[2]);
            int n4 = int.Parse(array[3]);

            float diferenca = ((float)n1 * (float)n2) - ((float)n3 * (float)n4);

            Console.WriteLine("Diferença: " + diferenca);
        }
    }
}