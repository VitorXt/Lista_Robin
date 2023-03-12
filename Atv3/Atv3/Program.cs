using Atv3;

ArquivoTexto arquivo = new ArquivoTexto();

arquivo.Conteudo = "Exemplo de conteúdo a ser salvo em arquivo.";
arquivo.EnderecoNomeArquivo = @"C:\temp\arquivo.txt";

if (arquivo.SalvarDadosArquivo())
{
    Console.WriteLine("Conteúdo salvo com sucesso!");
}
else
{
    Console.WriteLine("Falha ao salvar conteúdo.");
}

string conteudoArquivo = arquivo.PesquisarConteudoArquivo(arquivo.EnderecoNomeArquivo);
if (conteudoArquivo != "")
{
    Console.WriteLine("Conteúdo do arquivo:");
    Console.WriteLine(conteudoArquivo);
}
else
{
    Console.WriteLine("Falha ao buscar conteúdo.");
}