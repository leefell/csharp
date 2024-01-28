namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite uma coordenada: ");
            string[] array = Console.ReadLine().Split(' ');
            int x = int.Parse(array[0]);
            int y = int.Parse(array[1]);

            while(x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante.");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante.");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante.");
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante. ");
                }

                Console.WriteLine("Digite outra coordenada: ");
                array = Console.ReadLine().Split(' ');
                x = int.Parse(array[0]);
                y = int.Parse(array[1]);
            }
        }
    }
}