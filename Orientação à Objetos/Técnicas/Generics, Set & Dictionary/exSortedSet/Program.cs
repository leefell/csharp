namespace exSortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // O SortedSet ordena os elementos
            SortedSet<int> set1 = new SortedSet<int>() { 6, 4, 2, 5, 0, 8, 10 };
            SortedSet<int> set2 = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            // união
            SortedSet<int> set3 = new SortedSet<int>(set1); // estou instanciando um set3 com todos os elementos do set1
            set3.UnionWith(set2); //inserindo no set3 os elementos do set2 que não estão no set1
            CollectionPrinter(set3);

            // intersecção - elementos que existem nos dois conjuntos
            SortedSet<int> set4 = new SortedSet<int>(set1);
            set4.IntersectWith(set2);
            CollectionPrinter(set4);
            
            // diferença de conjuntos - elementos do set1 excluido aqueles que estão no set2
            SortedSet<int> set5 = new SortedSet<int>(set1);
            set5.ExceptWith(set2);
            CollectionPrinter(set5);
        }

        static void CollectionPrinter<T>(IEnumerable<T> collection) // IEnumerable é uma interface implementada por todas coleções básicas do system.collections
        {
            // foreach vai fun cionar em coleções que implementam o IEnumerable
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}