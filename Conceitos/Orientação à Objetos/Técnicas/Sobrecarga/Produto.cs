using System.Globalization;

namespace Sobrecarga
{
    internal class Produto
    {

        // Sobrecarga é um recuso que uma classe possui de oferecer mais de uma operação com o mesmo nome
        // só que com listas de parâmetros diferentes.

        public string Nome;
        public double Preco;
        public int Quantidade;

        // O construtor nesse caso está obrigando a entrada de dados

        public Produto()
        {
            // Construtor padrão
        }
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
