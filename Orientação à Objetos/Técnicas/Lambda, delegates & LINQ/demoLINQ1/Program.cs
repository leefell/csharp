namespace demoLINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Especificar o data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression (consulta)
            IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);
            // ou var result = (...)

            // Execute the query
            foreach (int x in result)
            {
                Console.Write(x + " ");
            }
        }
    }
}
