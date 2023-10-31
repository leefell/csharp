
namespace OpComparativos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            bool condicao1 = a < 10;
            bool condicao2 = a < 20;
            bool condicao3 = a > 10;
            bool condicao4 = a > 5;

            Console.WriteLine(condicao1);
            Console.WriteLine(condicao2);
            Console.WriteLine(condicao3);
            Console.WriteLine(condicao4);
            Console.WriteLine("--------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }
    }
}