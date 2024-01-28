namespace propriedadesMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instancia na memoria uma matriz de duas linhas e 3 colunas
            double[,] matriz = new double[2, 3];

            Console.WriteLine("Quantidade de elementos na matriz: " + matriz.Length);

            Console.WriteLine("Quantidade de linhas da matriz: " + matriz.Rank);

            Console.WriteLine("Tamanho da primeira dimensão (linhas): " + matriz.GetLength(0));
            Console.WriteLine("Tamanho da segunda dimensão (colunas): " + matriz.GetLength(1));
        }
    }
}