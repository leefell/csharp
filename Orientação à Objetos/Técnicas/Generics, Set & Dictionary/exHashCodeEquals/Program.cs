using Entities;

namespace exHashCodeEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com"};

            Console.WriteLine(a.Equals(b)); // output: false // aqui o compilador vai comprar o conteudo

            Console.WriteLine(a == b); // aqui o compilador vai comparar a referencia do ponteiro de memoria do obj

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            
        }
    }
}