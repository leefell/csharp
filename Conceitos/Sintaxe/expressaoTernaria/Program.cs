using System.Globalization;
namespace expressaoTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            //Preço é menor que 20? se sim recebe desconto de 10%, se não recebe um de 5;

            Console.WriteLine(desconto);

        }
    }
}