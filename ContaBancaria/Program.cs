using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Digite o número da sua Conta Bancária: ");
            /*contaCliente.NumeroConta = Console.ReadLine();*/
            string numeroConta = Console.ReadLine();

            Console.WriteLine("Digite o seu Nome: ");
            /*contaCliente.NomeCliente = Console.ReadLine();*/
            string nomeCliente = Console.ReadLine();


            Console.WriteLine("Deseja realizar um depósito inicial? \n 1)Sim  \n 2)Não");
            int resposta = int.Parse(Console.ReadLine());
            ContaCliente c1;

            if (resposta == 1)
            {
                Console.WriteLine("Digite o valor à ser depositado");
                double saldoInicial = double.Parse(Console.ReadLine());
                c1 = new ContaCliente(numeroConta, nomeCliente, saldoInicial);
            } else
            {
                c1 = new ContaCliente(numeroConta, nomeCliente);
            }

            Console.WriteLine("Digite o valor de saque. ATENÇÃO: É cobrado um valor de R$ 5,00 por cada saque realizado.");
            double valorDeposito = double.Parse(Console.ReadLine());
            c1.Saque(valorDeposito);

            Console.WriteLine("Obrigado por utilizar o nosso banco!");
        }
    }
}





