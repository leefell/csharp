namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            // É possível a concatenação acumulativa de String;

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);


            // x++ \ Saida: x = 11 / z = 10
            int x = 10;
            int z = x++;
            Console.WriteLine(x);
            Console.WriteLine(z);



            // ++x \ Saida: x = 10 / z = 11
            int x2 = 10;
            int z2= x++;
            Console.WriteLine(x2);
            Console.WriteLine(z2);
        }
    }
}