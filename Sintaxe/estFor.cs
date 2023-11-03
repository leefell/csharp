namespace est.For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de números inteiros: ");
            int qtd = int.Parse(Console.ReadLine());

            int soma = 0;
            for(int i = 1; i <= qtd; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }

            Console.WriteLine("Soma = " + soma);

        }

    }
}