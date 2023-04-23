using Atv5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv5
{
    public class Quadrado : Forma
    {
        public double LadoA;
        public double LadoB;
        public override void CalcularArea()
        {
            Area = LadoA * LadoB;
            Console.WriteLine($"A área do quadrado é:{Area}");
        }

        public override void CalcularPerimero()
        {
            Perimetro = (int)((LadoA * 2) + (LadoB * 2));
            Console.WriteLine($"O perímetro do quadrado é:{Perimetro}");
        }
    }
}
