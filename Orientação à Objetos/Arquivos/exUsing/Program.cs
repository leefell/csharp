﻿namespace exUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\leele\Documents\GitHub\csharp\Orientação à Objetos\Arquivos\Textos\e3\text1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred :/");
                Console.WriteLine(e.Message);
            }
        }
    }
}