namespace exDirectoryDInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Arquivos\Textos\e5";

            try
            {
                // listar todas subpastas            //mascara de formatação (qualquer arquivo . qualquer extensão)   
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                // pode se usar o var também, (var folder = ) 
                // IEnumerable é o tipo mais genérico de coleção
                Console.WriteLine("Folders: ");
                foreach (string s in folder)
                {
                    Console.WriteLine(s);
                }

                // listar todos os arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("\nFiles: ");
                foreach(string s in files)
                {
                    Console.WriteLine(s);
                }

                // criar uma subpasta à partir de uma pasta
                Directory.CreateDirectory(path + @"\newfolder");

            }
            catch (IOException e)
            {
                Console.WriteLine("Error :/");
                Console.WriteLine(e.Message);
            }
        }
    }
}