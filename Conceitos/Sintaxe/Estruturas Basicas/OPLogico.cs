namespace OpLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Operador &&, ambas condições devem ser verdadeiras.
            bool c1 = 2 > 3 && 4 != 5;
            Console.WriteLine(c1);

            // Operador !!, pelo menos uma condição deve ser verdadeira.
            bool c2 = 2 > 3 || 4 != 5; // true
            Console.WriteLine(c2);

            // Precedência: Não > E > Ou == ! > && > ||
            bool c3 = !(2 > 3) && 4 != 5; // true
            Console.WriteLine(c3);
            Console.WriteLine("-------");

            bool c4 = 10 < 5; // false
            bool c5 = c1 || c2 && c3; // true

            Console.WriteLine(c4);
            Console.WriteLine(c5);

        }
    }
}