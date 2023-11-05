using System.Globalization;
namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();
            double salarioMedio = 0;

            Console.WriteLine("Dados do Funcionário 1: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Funcionário 2: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            p2.salario =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (p1.salario + p2.salario) / 2;

            Console.WriteLine("Salario médio: " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}