using System.Globalization;

namespace AutoProperties
{
    internal class Produto
    {

        // Propriedades autoimplementadas são uma forma simplificada de se ddeclarar propriedades
        // que não precisam de lógica particulares para get e set.

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade{ get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public string Nome // Implementação de uma propriedade
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public override string ToString()
        {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade
                + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        } 
    }
}