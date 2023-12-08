using System.Globalization;
using System.Xml.Linq;

namespace Emprego
{
    internal class Empregado
    {

        public int ID{ get; set; }
        public string Nome { get; set; }
        public double Salario{ get; set; }

        public Empregado(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return ID
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
