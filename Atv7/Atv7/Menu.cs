using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv7
{
    class Menu : Empregado
    {
        public Menu()
        {
            Console.WriteLine("Qual o nome do colaborador: ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o sobrenome do colaborador: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Qual o CPF do colaborador: ");
            CPF = Console.ReadLine();
        }

        public void Menus()
        {
        Voltar:
            Console.WriteLine("Qual a função do colaborador?: \n" +
                "A. Assalariado\n" +
                "H. Horista\n" +
                "C. Comissionado\n");
            char _Menu = char.Parse(Console.ReadLine());

            switch (_Menu)
            {
                case 'A':
                    Assalariado _Assalariado = new Assalariado();
                    Console.WriteLine("Qual o valor do salario do colaborador: ");
                    double salariO = double.Parse(Console.ReadLine());
                    _Assalariado.Vencimento(salariO);
                    Console.WriteLine("Salario: " + _Assalariado.Salario);
                    break;

                case 'H':
                    Horista _Horista = new Horista();
                    Console.WriteLine("Qual o valor da hora trabalhada: ");
                    double hora_Trabalhada = double.Parse(Console.ReadLine());
                    _Horista.Vencimento(hora_Trabalhada);
                    Console.WriteLine("Total recebido: " + _Horista.salario_horas);
                    break;

                case 'C':
                    Comissionado _Comissionado = new Comissionado();
                    Console.WriteLine("Qual o valor da venda?: ");
                    double total_venda = double.Parse(Console.ReadLine());
                    _Comissionado.Vencimento(total_venda);
                    Console.WriteLine("Comissão retornada: " + _Comissionado.total);
                    break;

                default:
                    Console.WriteLine("Valor invalido");
                    goto Voltar;
                    break;

            }
        }
    }
}
