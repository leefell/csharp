using System.Runtime.CompilerServices;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            Console.WriteLine("Digite a Hora inicial e a hora final do jogo: ");
            string[] hora = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(hora[0]);
            horaFinal = int.Parse(hora[1]);

            if(horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo durou: " + duracao + " Hora(s)");
        }
    }
}