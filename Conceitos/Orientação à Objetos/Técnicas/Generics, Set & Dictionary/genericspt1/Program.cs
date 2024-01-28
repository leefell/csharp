namespace genericspt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Agora com o tipo generico o Typesafety esta habilitado 

            PrintService<int> printService = new PrintService<int>();
            //PrintService<string> printService = new PrintService<string>();

            Console.WriteLine("How many values: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.Write($"Input value {i + 1}: ");
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            //int a = printService.First();
            //int b = a + 2;
            //Console.WriteLine(b);

            printService.Print();

            Console.Write("\nFirst: " + printService.First());
            Console.Write("\nLast: " + printService.Last());

            PrintService<string> printService1 = new PrintService<string>();

            Console.WriteLine("\nHow many names: ");
            int m = int.Parse(Console.ReadLine());

            for(int j = 0; j < m; j++)
            {
                Console.WriteLine($"Input name {j + 1}: ");
                string nome = (Console.ReadLine());
                printService1.AddValue(nome);
            }

            printService1.Print();

            Console.Write("\nFirst: " + printService1.First());
            Console.Write("\nLast: " + printService1.Last());
        }
    }
}