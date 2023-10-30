using System.Security.AccessControl;

namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Casting -> conversão explícita de tipos
            // Pode jogar o conteudo de 8 bytes na variavel de 4, e o dev se responsabiliza por alguma perda de informação 
            // Se fizer o casting de double para int, ele vai arredondar, 5.1 -> 5

            double a;
            int b;

            a = 5.1;
            b = (int)a; 
            Console.WriteLine(b);


            int c = 5;
            int d = 2;
            double resultado = (double)c / d; // Dessa maneira não vai descartar as casas decimais.
            Console.WriteLine(resultado);


        }
    }
}