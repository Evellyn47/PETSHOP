using System;
using petshop.Models;

class Program
{
    static void Main()
    {
        GerenciadorAgendamento petshop = new GerenciadorAgendamento();
        bool sair = false;

        do
        {
            Console.WriteLine("\n=== PETSHOP - AGENDAMENTO DE BANHO ===");
            Console.Write("Escolha uma opção: ");
            Console.WriteLine("[1] Realizar agendamento");
            Console.WriteLine("[2] Cancelar agendamento");
            Console.WriteLine("[3] Listar clientes");
            Console.WriteLine("[0] Sair");
        

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    petshop.AgendarCliente();
                    break;
                case "2":
                    petshop.CancelarAgendamento();
                    break;
                case "3":
                    petshop.ListarClientes();
                    break;
                case "0":
                    sair = true;
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (!sair);
    }
}
