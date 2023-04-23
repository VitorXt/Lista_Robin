using Atv6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv6
{
    public class Imprimir
    {
        Documento documento = new Documento();
        public void EnviarImpressao()
        {
            Impressora imp = new Impressora(documento);
            imp.Imprimir();
        }

        public void SolicitarTexto()
        {
            Console.WriteLine("Digite aqui o texto que deseja imprimir:");
            documento.texto = Console.ReadLine();
        }
    }
}
