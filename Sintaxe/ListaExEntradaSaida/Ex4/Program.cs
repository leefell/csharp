using System.Globalization;
namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de um funcionário");
            string numero = Console.ReadLine();

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que o Funcionário recebe por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorHora;

            Console.WriteLine("Numero do Funcionario: " + numero);
            Console.WriteLine("Salario: U$" +  salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}