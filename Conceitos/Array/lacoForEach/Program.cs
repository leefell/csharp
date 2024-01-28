namespace lacoForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] vetor = new string[] { "Gabriel", "Josué", "Marcelo" };

            Console.WriteLine("For");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine("\n\nForEach:");

            foreach(string nomes in vetor)
            {
                Console.WriteLine(nomes);
            }

        }
    }
}