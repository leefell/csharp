namespace interfaceComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Fundamentos OO\Interface\nomes.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> lista = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        lista.Add(sr.ReadLine());
                    }
                    lista.Sort(); // ordernar lista
                    foreach(string s in lista)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :/");
                Console.WriteLine(e.Message);
            }
        }
    }
}