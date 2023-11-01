using System;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("1 - Álcool.");
            Console.WriteLine("2 - Gasolina.");
            Console.WriteLine("3 - Diesel.");
            Console.WriteLine("4 - Sair.");
            Console.WriteLine("-------------");
            Console.WriteLine("Qual sua preferência: ");

            int preferencia = int.Parse(Console.ReadLine());
            while(preferencia != 4)
            {
                if(preferencia == 1)
                {
                    alcool++;
                }
                else if(preferencia == 2)
                {
                    gasolina++;
                }
                else
                {
                    diesel++;
                }

                Console.WriteLine("Novo voto: ");
                preferencia = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Muito Obrigado! ");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}