using System.Net.NetworkInformation;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'M';
            char letra = '\u0041'; // O /u significa que é um código em unicode
            bool completo = false;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;   // esse f é para indicar que o dado é do tipo float
            double n6 = 4.5;
            string nome = "Alexandre Augusto"; // Imutável, sendo mais seguro
            object obj1 = "Gabriel Tangerina"; // Obj é um tipo genérico de dado, tipo o var do java
            object obj2 = 100f;

            Console.WriteLine("Exemplo de tipos de dados: ");
            Console.WriteLine("Char: " + genero);
            Console.WriteLine("Unicode: "+ letra);
            Console.WriteLine("Booleano: " + completo);
            Console.WriteLine("Byte: " + n1);
            Console.WriteLine("Inteiro (Não está no limite): " + n2);
            Console.WriteLine("Inteiro: " + n3);
            Console.WriteLine("Long: " + n4);
            Console.WriteLine("Float: " + n5);
            Console.WriteLine("Double: " + n6);
            Console.WriteLine("String: " + nome);
            Console.WriteLine("Object: " + obj1);
            Console.WriteLine("Object: " + obj2);

            Console.WriteLine("\nTestando Funções: ");

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            sbyte n10 = sbyte.MaxValue;
            decimal n11 = decimal.MinValue;
            decimal n12 = decimal.MaxValue; 

            Console.WriteLine("\nInteiro: ");
            Console.WriteLine("Valor Mínimo: " + n7);
            Console.WriteLine("Valor Máximo: " + n8);

            Console.WriteLine("\nByte: ");
            Console.WriteLine("Valor Mínimo: " + n9);
            Console.WriteLine("Valor Máximo: " + n10);

            Console.WriteLine("\nDecimal: ");
            Console.WriteLine("Valor Mínimo: " + n11);
            Console.WriteLine("Valor Máximo: " + n12);
        }
    }
}