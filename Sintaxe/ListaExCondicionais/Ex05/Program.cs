using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Globalization;
namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float total = 0.0f;

            Console.WriteLine("CODIGO          ESPECIFICAÇÃO          PREÇO");
            Console.WriteLine("  1             Cachorro-Quente        R$4.00");
            Console.WriteLine("  2             X-Salada               R$4.50");
            Console.WriteLine("  3             X-Bacon                R$5.00");
            Console.WriteLine("  4             Torrada simples        R$2.00");
            Console.WriteLine("  5             Refrigerante           R$1.50");
            Console.WriteLine("Opcão: ");

            string[] array = Console.ReadLine().Split(' ');
            int codigo = int.Parse(array[0]);
            int quantidade = int.Parse(array[1]);

            if(codigo == 1)
            {
                total = quantidade * 4;
            }
            else if(codigo == 2)
            {
                total = quantidade * 4.5f;
            }
            else if(codigo == 3)
            {
                total = quantidade * 5;
            }
            else if(codigo == 4)
            {
                total = quantidade * 2;
            }
            else if(codigo == 5)
            {
                total = quantidade * 1.5f;
            }
            else
            {
                Console.WriteLine("Opção Inválida zé!");
            }

            Console.WriteLine("Total à pagar R$: " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}