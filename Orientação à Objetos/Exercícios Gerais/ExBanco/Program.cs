using System.Globalization;
namespace ExBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco pessoa;

            Console.Write("Insira o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Insira o Titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n): ");
            char opc = char.Parse(Console.ReadLine());
            if(opc == 's' || opc == 'S')
            {
                Console.Write("Digite o valor do depósito incial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                pessoa = new Banco(numero, titular, depositoInicial);
            }
            else
            {
                pessoa = new Banco(numero, titular);
            }

            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(pessoa);

            Console.Write("Insira um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.Deposito(deposito);

            Console.WriteLine("\nDados Atualizados!");
            Console.WriteLine(pessoa);

            Console.WriteLine("Existe uma taxa de $5 por saque.");
            Console.Write("Insira um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.Saque(saque);

            Console.WriteLine("\nDados Atualizados!");
            Console.WriteLine(pessoa);
        }
    }
}