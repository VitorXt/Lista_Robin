using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    public class Horista : Empregado
    {
        public double PrecoHora { get; set; }
        public double HorasTrabalhadas { get; set; }
        public override double Vencimento()
        {
            return PrecoHora * HorasTrabalhadas;
        }
    }
}
