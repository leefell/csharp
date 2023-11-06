using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Aluno
    {

        public string nome;
        public double n1, n2, n3;

        public double NotaFinal()
        {
            return n1 + n2 + n3;
        }

        public bool Aprovado()
        {
            if(NotaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}
