using System.ComponentModel;
using System.Xml;
using System.Globalization;
namespace EntradaDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] array = Console.ReadLine().Split(' ');
            string nome = array[0];
            char sexo = char.Parse(array[1]);
            int idade = int.Parse(array[2]);
            double altura = double.Parse(array[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Voce digitou: " + n1);
            Console.WriteLine("Char: " + ch);
            Console.WriteLine("Double: " + n2.ToString("F2"), CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}