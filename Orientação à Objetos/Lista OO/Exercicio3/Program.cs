using System.Globalization;
namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado.");
            }
            else
            {
                Console.WriteLine("Reprovado.");
                Console.WriteLine("Faltam " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }
        }
    }
}