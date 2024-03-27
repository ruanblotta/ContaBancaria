using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nConta;
            double saldo = 0;
           
            // Chaves de Acesso

            Console.WriteLine("Digite o número da sua Conta Bancária: ");
            nConta = Console.ReadLine();

            Console.WriteLine("Digite o seu Nome: ");
            nome = Console.ReadLine();

            if (nome == "Ruan" && nConta == "12345")
            {
                Console.WriteLine("Acesso Aprovado. Seja bem vindo " + nome);
            } else
            {
                Console.WriteLine("Acesso Negado. Tente Novamente.");
            }

            // Funcionalidade de Depósito 

            Console.WriteLine($"Seu saldo atual é de: R$ {saldo.ToString("F2")} ");

            Console.WriteLine("Digite o valor à ser depositado");
            double deposito = double.Parse(Console.ReadLine());

            double saldoAtual = saldo += deposito;
            Console.WriteLine($"O depósito de R$ {deposito.ToString("F2")} foi feito com sucesso!");


            Console.WriteLine("Seu saldo atual é de: R$ " + saldoAtual.ToString("F2"));

            // Funcionalidade de Saque e a Cobrança de Taxa de Saque

            Console.WriteLine("Digite o valor de saque. ATENÇÃO: É cobrado um valor de R$ 5,00 por cada saque realizado.");
            double saque = double.Parse(Console.ReadLine());
            double taxaSaque = 5.00;
            double saldoAtualizado = (saldoAtual - taxaSaque) - saque;

            Console.WriteLine("Seu saldo atual é de: R$" + saldoAtualizado.ToString("F2"));
           
        }
    }
}
