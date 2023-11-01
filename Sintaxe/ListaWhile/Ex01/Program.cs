using System.Xml;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int senhaCorreta = 2002;

            Console.Write("Digite a senha: ");
            int tentativa = int.Parse(Console.ReadLine());

            while(tentativa != senhaCorreta)
            {
                Console.WriteLine("Senha incorreta.");
                Console.Write("Digite novamente: ");
                tentativa = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine("Senha Correta, acesso permitido.");
        }
    }
}