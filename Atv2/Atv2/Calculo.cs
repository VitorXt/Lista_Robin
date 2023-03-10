using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv2
{
    public class Calculo
    {
        public double Resultado;
        public double ValorA;
        public double ValorB;

        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
            ImprimirResultado();
        }

        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB;
            ImprimirResultado();
        }

        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
            ImprimirResultado();
        }

        public double RetornarMaior()
        {

            double maiorValor;
            if (ValorA > ValorB)
            {
                return ValorA;
            }
            else
            {
               return ValorB;
            }
        }

        public double SomarGeral(double valor)
        {
            return valor + ValorA + ValorB;

        }

        public void ImprimirResultado(){
            Console.WriteLine($"O resultado é: {Resultado}");
        }
    }
}
