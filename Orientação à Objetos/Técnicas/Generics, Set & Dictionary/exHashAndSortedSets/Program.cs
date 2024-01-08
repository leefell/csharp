namespace exHashAndSortedSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("Café");
            set.Add("Notebook");
            set.Add("Celular");

            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine(set.Contains("Tangerina"));
            foreach(string coisa in set)
            {
                Console.WriteLine("\n" + coisa);
            }

            set.Clear(); // limpa o set
            foreach(string coisa in set)
            {
                Console.WriteLine("\n" + coisa); // output: null
            }
        }
    }
}