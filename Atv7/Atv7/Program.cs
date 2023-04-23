using Atv7;

void Menu()
{
    int tipoEmpregado = 0;
    do
    {
        Console.WriteLine("O empregado é \n 1-Assalariado \n 2-Comissionado \n 3-Horista \n 4-Sair");
        tipoEmpregado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o nome do empregado: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Digite o sobrenome do empregado: ");
        var sobrenome = Console.ReadLine();
        Console.WriteLine("Digite o cpf do empregado: ");
        var cpf = Console.ReadLine();

        switch (tipoEmpregado)
        {
            case 1:

                Assalariado assalariado = new Assalariado();
                assalariado.Nome = nome;
                assalariado.Sobrenome = sobrenome;
                assalariado.Cpf = cpf;
                Console.WriteLine("Digite o salario do empregado: ");
                assalariado.Salario = Convert.ToDouble(Console.ReadLine());
                assalariado.Vencimento();
                break;

            case 2:

                Comissionado comissionado = new Comissionado();
                comissionado.Nome = nome;
                comissionado.Sobrenome = sobrenome;
                comissionado.Cpf = cpf;
                Console.WriteLine("Digite o total de vendas do empregado: ");
                comissionado.TotalVenda = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a taxa de comissao do empregado: ");
                comissionado.TaxaComissao = Convert.ToDouble(Console.ReadLine());
                comissionado.Vencimento();
                break;

            case 3:

                Horista horista = new Horista();
                horista.Nome = nome;
                horista.Sobrenome = sobrenome;
                horista.Cpf = cpf;
                Console.WriteLine("Digite o valor da hora do empregado: ");
                horista.PrecoHora = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o total de horas trabalhadas do empregado: ");
                horista.HorasTrabalhadas = Convert.ToDouble(Console.ReadLine());
                horista.Vencimento();
                break;

            case 4:

                Console.WriteLine("Saindo...");
                break;

            default:

                Console.WriteLine("Escolha uma opção válida");
                break;
        }
    } while (tipoEmpregado != 4);
}
Menu();
