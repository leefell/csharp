using System;
namespace bubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de elementos do array: ");
            int nElementos = int.Parse(Console.ReadLine());

            int[] array = new int[nElementos];

            for (int i = 0; i < nElementos; i++)
            {
                Console.Write("Digite o elemento " + (i + 1) + ": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Array original: ");
            mostrar(array);

            BSort(array);

            Console.WriteLine("\nArray após o sorting: ");
            mostrar(array);
        }

        static void BSort(int[] array)
        {
            int n = array.Length;

            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static void mostrar(int[] array)
        {

            foreach(int elemento in array)
            {
                Console.Write(elemento + " ");
            }

        } 
    }
}