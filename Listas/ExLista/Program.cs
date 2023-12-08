using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listinha = new List<string>(); // cria uma lista vazia

            listinha.Add("Alexandre");  // 0
            listinha.Add("Gabriel");   // 1
            listinha.Add("Callegari"); // 2
            listinha.Add("Marcelo");  // 3
            listinha.Add("Aurélio");
            listinha.Add("Camile");
            listinha.Insert(2, "Josué");
            listinha.Insert(3, "Francisco");

            foreach(string nomes in  listinha)
            {
                Console.WriteLine(nomes);
            }
            Console.WriteLine("\nTamanho da lista: " + listinha.Count);

            //a funcao find recebe como argumento uma funcao
            string s1 = listinha.Find(x => x[0] == 'A');
            Console.WriteLine("\nA primeira pessoa que começa com 'A': " + s1);

            string s2 = listinha.FindLast(x => x[0] == 'A');
            Console.WriteLine("A última pessoa que começa com 'A': " + s2);

            int posicao1 =  listinha.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\nPrimeira posição começando com 'A': " + posicao1);

            int posicao2 = listinha.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("A ultima posição de quem começa com 'A': " + posicao2);

            // Filtrar lista com todos nomes que tenha 9 caracteres

            Console.WriteLine("\nFiltrando nomes com 9 caracteres:");
            List<string> listaFiltrada = listinha.FindAll(x => x.Length == 9);
            
            foreach(string nome in listaFiltrada)
            {
                Console.WriteLine(nome);
            }

            // Remover elementos da lista

            Console.WriteLine("\nRemovendo elementos: ");
            listinha.Remove("Alexandre");
            foreach(string nome in listinha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nRemovendo todos da lista que começam com 'C'");
            listinha.RemoveAll(x => x[0] == 'C');
            foreach (string nome in listinha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nRemovendo elemento pela posição.");
            listinha.RemoveAt(2);
            foreach(string nome in listinha)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\nRemovendo elemento pela posição e contador.");
            listinha.RemoveRange(2, 2);
            foreach (string nome in listinha)
            {
                Console.WriteLine(nome);
            }
        }
    }
}