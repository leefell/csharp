namespace exStreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Arquivos\Textos\e4\text1.txt";
            string targetPath = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Arquivos\Textos\e4\text2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}