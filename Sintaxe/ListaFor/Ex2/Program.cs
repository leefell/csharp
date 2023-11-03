using System.Diagnostics.Contracts;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor inteiro para controle: ");
            int qtd = int.Parse(Console.ReadLine());
            int dentro = 0, fora = 0;

            for(int i = 0; i < qtd; i++)
            {

                Console.Write("\nDigite um número: ");
                int n = int.Parse(Console.ReadLine());

                if (n >= 10 && n <= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;    
                }
            }

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}