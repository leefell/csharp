namespace Aluguel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente[] pessoa = new Cliente[10];

            Console.Write("Quantos quartos serão alugados: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("\nAluguel #" + (i));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                pessoa[quarto] = new Cliente(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if (pessoa[i] != null)
                {
                    Console.WriteLine(i + ": " + pessoa[i]);
                }
            }

        }
    }
}