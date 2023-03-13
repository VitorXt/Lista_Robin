using Atv4;

List<string> alunos = new List<string>();

Aluno cadastronota = new Aluno();

Console.Write("Quantos alunos deseja cadastrar: ");
int qtdAlunos = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdAlunos; i++)
{
    Console.WriteLine();

    Console.Write($"Digite o seu RA: ");
    cadastronota.RA = Console.ReadLine();
    //string RA = Console.ReadLine();
    alunos.Add(cadastronota.RA);

    Console.Write($"Digite o seu nome: ");
    cadastronota.nome = Console.ReadLine();
    //string nome = Console.ReadLine();
    alunos.Add(cadastronota.nome);

    Console.Write($"Digite a nota de sua prova: ");
    cadastronota.notaprova = Convert.ToInt32(Console.ReadLine());
    string notaprova = Console.ReadLine();
    alunos.Add(notaprova);

    Console.Write($"Digite a nota de seu trabalho: ");
    cadastronota.notatrabalho = Convert.ToInt32(Console.ReadLine());
    string notatrabalho = Console.ReadLine();
    alunos.Add(notatrabalho);

}

foreach (string campo in alunos)
{
    //Console.WriteLine($"\nAlunos cadastrados:{qtdAlunos}");
    Console.WriteLine();
    cadastronota.CalcularMedia();
    cadastronota.CalcularNotaFinal(cadastronota.notafinal);
    cadastronota.ImprimirNotaFinal();
    cadastronota.ReceberDados();
}