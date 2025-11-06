using System;

namespace petshop.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Codigo { get; set; }
        public int QuantidadeGato { get; set; }
        public int QuantidadeCachorro { get; set; }

        public Cliente(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public void AdicionarAnimais()
        {
            int tipo;
            while (true)
            {
                Console.WriteLine("Qual é o tipo do seu pet para dar banho?");
                Console.WriteLine("(1) Gato");
                Console.WriteLine("(2) Cachorro");
                Console.WriteLine("(3) Cachorro e Gato");
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out tipo) && tipo >= 1 && tipo <= 3)
                    break;
                else
                    Console.WriteLine("Opção inválida! Tente novamente.\n");
            }
                if (tipo == 1)
{
    do
    {
        Console.Write("Quantos gatos? ");
        QuantidadeGato = LerNumero();
        if (QuantidadeGato <= 0)
            Console.WriteLine("O número de gatos deve ser maior que 0!");
    } while (QuantidadeGato <= 0);
}
             else if (tipo == 2) 
{
    do
    {
        Console.Write("Quantos cachorros? ");
        QuantidadeCachorro = LerNumero();
        if (QuantidadeCachorro <= 0)
            Console.WriteLine("O número de cachorros deve ser maior que 0!");
    } while (QuantidadeCachorro <= 0);
}
else 
{
    do
    {
        Console.Write("Quantos gatos? ");
        QuantidadeGato = LerNumero();
        if (QuantidadeGato <= 0)
            Console.WriteLine("O número de gatos não pode ser 0!");
    } while (QuantidadeGato <= 0);

    do
    {
        Console.Write("Quantos cachorros? ");
        QuantidadeCachorro = LerNumero();
        if (QuantidadeCachorro <= 0)
            Console.WriteLine("O número de cachorros não pode ser 0!");
    } while (QuantidadeCachorro <= 0);
}

        }

        private int LerNumero()
        {
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.Write("Valor inválido! Digite novamente: ");
            }
            return numero;
        }

        public void Mostrar()
        {
            Console.Write($"{Nome} ");
            if (QuantidadeGato > 0)
                Console.Write($"{QuantidadeGato} gatos ");
            if (QuantidadeCachorro > 0)
                Console.Write($"{QuantidadeCachorro} cachorros ");
            Console.WriteLine("para o banho.");
        }
    }
}
