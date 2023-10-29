using System;
using System.Globalization;

namespace SaidaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35234;
            string nome = "Rafael";

            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde");
            Console.WriteLine("Boa noite");
            Console.WriteLine("----------------------------");

            Console.WriteLine(saldo.ToString("F2")); // Arredonda e imprime com duas casas decimais.
            Console.WriteLine(saldo.ToString("F4")); // 4 casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // O InvariantCulture vai desconsiderar qualquer separação específica de pais
            Console.WriteLine("----------------------------");

            // PlaceHolder 

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);

            // Interpolação

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");

            // Concatenação de String

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
        }
    }
}