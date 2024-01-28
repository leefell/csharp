namespace Funcoes
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            // Em OO funções recebem o nome de métodos.

            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            double resultado2 = Maior(700, 231, 1000);

            Console.WriteLine("Maior = " + resultado);
            Console.WriteLine("Maior = " + resultado2);
        }

        static int Maior(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}