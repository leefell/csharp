using System.Globalization;

namespace V2ComStatic 
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // As operações da classe Calculadora são idependentes de objeto, entao se adicionar o 'static' nao é preciso
            // Instanciar nada, voce faz a chamada diretamente a partir do nome da classe.

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}