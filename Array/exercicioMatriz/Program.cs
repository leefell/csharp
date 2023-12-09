namespace exercicioMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordem da matriz quadradada: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tamanho, tamanho];

            Console.WriteLine("Preencher a matriz: ");
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write("Elemento " + i + ", " + j + ": ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz preenchida: ");
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine(); 
            }

            Console.WriteLine("Diagonal Principal: ");
            for(int i = 0; i < tamanho; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            int contador = 0;
            for(int i = 0; i < tamanho; i++)
            {
                for(int j = 0; j < tamanho; j++)
                {
                    if (matriz[i,j] < 0)
                    {
                        contador++;
                    }
                }
            }
            Console.WriteLine("Quantidade de números negativos: " + contador);
        }
    }
}