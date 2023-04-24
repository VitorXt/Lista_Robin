using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    class Comissionado : Empregado
    {
        private double Total_venda { get; set; }
        public double Total_Comissao { get; private set; }
        public double total { get; private set; }

        public Comissionado()
        {
            Total_Comissao = 0.03;
        }

        public override double Vencimento(double venda)
        {
            venda = Total_venda;
            total = Total_Comissao * Total_venda;
            return total;
        }
    }
}
