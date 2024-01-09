namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<int> CursoA = new HashSet<int>();
            HashSet<int> CursoB = new HashSet<int>();
            HashSet<int> CursoC = new HashSet<int>();

            Console.Write("Quantos estudantes para o Curso A: ");
            int nA = int.Parse(Console.ReadLine());
            for (int i = 0; i < nA; i++)
            {
                Console.Write($"Digite o ID#{i + 1}: ");
                int idA = int.Parse(Console.ReadLine());
                CursoA.Add(idA);
            }

            Console.Write("\nQuantos estudantes para o Curso B: ");
            int nB = int.Parse(Console.ReadLine());
            for (int i = 0; i < nB; i++)
            {
                Console.Write($"Digite o ID#{i + 1}: ");
                int idB = int.Parse(Console.ReadLine());
                CursoA.Add(idB);
            }

            Console.Write("\nQuantos estudantes para o Curso C: ");
            int nC = int.Parse(Console.ReadLine());
            for (int i = 0; i < nC; i++)
            {
                Console.Write($"Digite o ID#{i + 1}: ");
                int idC = int.Parse(Console.ReadLine());
                CursoA.Add(idC);
            }

            HashSet<int> total = new HashSet<int>(CursoA);
            total.UnionWith(CursoB);
            total.UnionWith(CursoC);

            Console.WriteLine("\nO total de alunos inscritos foram: " + total.Count);

        }
    }
}