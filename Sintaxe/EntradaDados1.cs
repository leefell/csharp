using System.Numerics;

namespace EntradaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // Função Split - Recortar o string em varios pedaços baseado nas ' '.

            string s = Console.ReadLine(); // Vai ler a linha inteira e guardar na variavel s.
            string[] v = s.Split(' '); // Vai recortar a string s com base nos espaços em branco e vai guardar em um vetor;
            string a = v[0]; 
            string b = v[1];
            string c = v[2];

            string[] w = Console.ReadLine().Split(' '); // Dessa maneira não precisa fazer o Console.ReadLine antes
            string e = w[0];
            string f = w[1];
            string g = w[2];

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}