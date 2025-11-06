using System;
using System.Collections.Generic;

namespace petshop.Models
{
    public class GerenciadorAgendamento
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void AgendarCliente()
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Crie um código numérico: ");
            int.TryParse(Console.ReadLine(), out int codigo);

            Cliente novoCliente = new Cliente(nome, codigo);
            novoCliente.AdicionarAnimais();

            Console.Write("Confirmar agendamento (S/N)? ");
            string resposta = Console.ReadLine().ToUpper();
            if (resposta == "S")
            {
                clientes.Add(novoCliente);
                Console.WriteLine("\nAgendamento realizado!\n");
            }
            else
            {
                Console.WriteLine("\nAgendamento cancelado.\n");
            }
        }

        public void CancelarAgendamento()
        {
            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

    
            Cliente cliente = null;
            foreach (var c in clientes)
            {
                if (c.Nome.ToUpper() == nome.ToUpper())
                {
                    cliente = c;
                    break;
                }
            }

            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            Console.Write("Digite o código: ");
            int.TryParse(Console.ReadLine(), out int codigo);

            if (codigo == cliente.Codigo)
            {
                Console.Write("Confirmar cancelamento (S/N)? ");
                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    clientes.Remove(cliente);
                    Console.WriteLine("Agendamento cancelado!");
                }
                else
                {
                    Console.WriteLine("Cancelamento não confirmado.");
                }
            }
            else
            {
                Console.WriteLine("Código incorreto.");
            }
        }

        public void ListarClientes()
        {
            Console.WriteLine("\n=== Clientes Agendados ===");
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente agendado.");
                return;
            }

            foreach (var c in clientes)
            {
                c.Mostrar();
            }
        }
    }
}
