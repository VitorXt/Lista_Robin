using Atv3;

ArquivoTexto arquivo = new ArquivoTexto();

arquivo.Conteudo = "Texto para a atividade 3 do Robin.";
arquivo.EnderecoNomeArquivo = @"C:\temp\jureg.txt";

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