using System.Globalization;
namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario = new Funcionario();
            
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + funcionario);
            Console.WriteLine("Digite a porcentagem do aumento: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados Atualizados: " + funcionario);
        }
    }
}