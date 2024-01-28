namespace exercicioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Técnicas\Generics, Set & Dictionary\text\votos.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> dVotos = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] lines = sr.ReadLine().Split(",");
                        string name = lines[0];
                        int votos = int.Parse(lines[1]);

                        if (dVotos.ContainsKey(name))
                        {
                            dVotos[name] += votos;
                        }
                        else
                        {
                            dVotos[name] = votos;
                        }
                    }
                    foreach (KeyValuePair<string, int> keyVotos in dVotos)
                    {
                        Console.WriteLine(keyVotos.Key + ": " + keyVotos.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Oops! Something went wrong." + e.Message);
            }
        }
    }
}