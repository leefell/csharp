namespace exercicioMatriz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            for(int i = 0; i < matriz.GetLength(0); i++) // tamanho da linhas 
            {
                for(int j = 0; j < matriz.GetLength(1); j++) // tamanho de colunas
                {
                    Console.Write("Digite o elemento " + i + ", " + j + ": ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nMatriz preenchida: ");
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++) // tamanho de colunas
                {
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Digite um número pra verificar: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Posição " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + matriz[i - 1, j]);
                        }
                        if (j < linhas - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }
                        if (i < colunas - 1)
                        {
                            Console.WriteLine("Baixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}