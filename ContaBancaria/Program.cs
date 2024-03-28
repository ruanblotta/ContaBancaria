using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCliente contaCliente = new ContaCliente("12345", "Ruan"); 
           
            Console.WriteLine("Digite o número da sua Conta Bancária: ");
            contaCliente.NumeroConta = Console.ReadLine();

            Console.WriteLine("Digite o seu Nome: ");
            contaCliente.NomeCliente = Console.ReadLine();

            contaCliente.AcessoContaBancaria();

            contaCliente.SaldoInicial();
            contaCliente.Deposito();
            contaCliente.Saque();
            /*contaCliente.SaldoAtualConta();*/

            Console.WriteLine("Obrigado por utilizar o nosso banco!");
        }
    }
}
