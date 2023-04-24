using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    abstract class Empregado
    {
        protected string nome { get; set; }
        protected string sobrenome { get; set; }
        protected string CPF { get; set; }

        public virtual double Vencimento(double variavel) { return variavel; }
    }
}
