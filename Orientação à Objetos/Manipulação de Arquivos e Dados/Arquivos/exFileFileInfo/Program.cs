using System.IO;

namespace exFileFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // colocando o '@' não precisa colocar duas barras \\leele\\Documents\\etc
            string sourcePath = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Arquivos\Textos\text1.txt";
            string targetPath = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Arquivos\Textos\text2.txt";

            try
            {

                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An erro ocurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}