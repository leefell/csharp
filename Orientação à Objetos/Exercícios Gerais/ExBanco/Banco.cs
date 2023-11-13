using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ExBanco
{
    internal class Banco
    {

        public int Numero {  get; private set; }
        public string Titular { get; set; }
        public double Saldo {  get; private set; }


        public Banco(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Banco(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial); // É interessante fazer dessa maneira porque se a logica do Deposito
                                       // um dia mudar, ele ja vai alterar aqui
        }


       public void Deposito(double quantia)
        {

            Saldo += quantia;

        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular +
                ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);  
        }
    }
}
