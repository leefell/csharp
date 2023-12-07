namespace modificadorParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int soma1 = Calculadora.Soma(1, 2, 3, 4, 5, 6, 7);
            int soma2 = Calculadora.Soma(2, 4, 3 );

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);

        }
    }
}