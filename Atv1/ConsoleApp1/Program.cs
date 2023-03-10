using Atividade1;

Aluno cadastronota = new Aluno();

Console.Write($"Digite o seu RA: ");
cadastronota.RA = Console.ReadLine();

Console.Write($"Digite o seu nome: ");
cadastronota.nome = Console.ReadLine();

Console.Write($"Digite a nota de sua prova: ");
cadastronota.notaprova = Convert.ToInt32(Console.ReadLine());

Console.Write($"Digite a nota de seu trabalho: ");
cadastronota.notatrabalho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
cadastronota.CalcularMedia();
cadastronota.CalcularNotaFinal(cadastronota.notafinal);
cadastronota.ImprimirNotaFinal();
cadastronota.ReceberDados();