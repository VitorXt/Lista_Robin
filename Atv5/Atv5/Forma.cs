using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv5
{
    public class Forma
    {
        public double Area {  get; set; }
        public int Perimetrro { get; set; }

        public virtual void CalcularArea()
        {

        }

        public virtual void CalcularPerimetro()
        {

        }
    }
}
