using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    class Assalariado : Empregado
    {
        public double Salario { get; private set; }
        public override double Vencimento(double salario)
        {
            Salario = salario;
            return Salario;
        }
    }
}
