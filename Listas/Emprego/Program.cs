using System.Globalization;
using System.Collections.Generic;
namespace Emprego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos empregados serão registrados: ");
            int nEmpregados = int.Parse(Console.ReadLine());

            List<Empregado> pessoa = new List<Empregado>();

            for(int i = 1; i <= nEmpregados; i++)
            {
                Console.WriteLine("\nEmpregado #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                pessoa.Add(new Empregado(id, nome, salario));
            }

            Console.Write("\nDigite o ID do empregado cujo salário terá um aumento: ");
            int chaveBusca = int.Parse(Console.ReadLine());

            Empregado aux = pessoa.Find(x => x.ID == chaveBusca);
            if(aux != null)
            {
                Console.WriteLine("\nDigite a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aux.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("\nEsse ID não está cadastrado.");
            }

            Console.WriteLine("\nLista de empregados atualizada: ");
            foreach(Empregado nome in pessoa)
            {
                Console.WriteLine(nome);
            }
        }
    }
}