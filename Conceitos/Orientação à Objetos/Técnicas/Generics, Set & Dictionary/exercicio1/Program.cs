//C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Técnicas\Generics, Set & Dictionary\text\in.txt
using Entities;

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite o caminho completo do arquivo: ");
            //string path = Console.ReadLine();

            HashSet<RegistroDeLog> logs = new HashSet<RegistroDeLog>(); 

            string path = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Técnicas\Generics, Set & Dictionary\text\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string nome = line[0];
                        DateTime instante = DateTime.Parse(line[1]);

                        logs.Add(new RegistroDeLog(nome, instante));
                    }
                    Console.WriteLine("Total Users: " + logs.Count);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Something went wrong! :/");
                Console.WriteLine(ex.Message);
            }
        }
    }
}