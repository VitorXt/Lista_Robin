using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv3
{
    public class ArquivoTexto
    {
        public string Conteudo;
        public string EnderecoNomeArquivo;

        public bool SalvarDadosArquivo()
        {
            try
            {
                File.WriteAllText(EnderecoNomeArquivo, Conteudo);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string PesquisarConteudoArquivo(string endereco)
        {
            try
            {
                return File.ReadAllText(endereco);
            }
            catch
            {
                return "";
            }
        }
    }
}