// this -> referencia para o proprio objeto
namespace PalavraTHIS
{
    internal class Program
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Program()
        {
            Quantidade = 10;
        }

        // Nesse sentido o this é indicado que ao chamar esse construtor, deve chamar o construtor padrao também.
        public Program(string nome, double preco) : this() 
        {
            Nome = nome;
            Preco = preco;
        }

        // Chamando o construtor anterior.
        public Program(string nome, double preco, int Quantidade): this(nome, preco)
        {
            Quantidade = quantidade;
        }

    }
}
