using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    public class ContaCliente
    {
        public string NumeroConta;
        public string NomeCliente;
        public double Saldo = 0;
        public double SaldoAtual;
 

        // Construtor para o cliente acessar a conta

        public ContaCliente(string numeroConta, string nomeCliente)
        {
            NumeroConta = numeroConta;
            NomeCliente = nomeCliente;
        }

        // Método para acessar a conta
        public void AcessoContaBancaria()
        {
            
            if (NomeCliente == "Ruan" && NumeroConta == "12345")
            {
                Console.WriteLine("Acesso Aprovado. Seja bem vindo " + NomeCliente);
            }
            else
            {
                Console.WriteLine("Acesso Negado. Tente Novamente.");
            }
        }

        // Método de Depósito 

        public void Deposito()
        {
            Console.WriteLine("Digite o valor à ser depositado");
            double deposito = double.Parse(Console.ReadLine());

            Saldo += deposito;
            Console.WriteLine($"O depósito de R$ {deposito.ToString("F2")} foi feito com sucesso!");
        }

        // Método de Saque e a Cobrança de Taxa de Saque
        public void Saque()
        {
            Console.WriteLine("Digite o valor de saque. ATENÇÃO: É cobrado um valor de R$ 5,00 por cada saque realizado.");
            double saque = double.Parse(Console.ReadLine());
            double taxaSaque = 5.00;

            Saldo -= (saque + taxaSaque);
            Console.WriteLine("Seu saldo atual é de: R$" + Saldo.ToString("F2"));
        }

        // método verificador de saldo

    /*    public void SaldoAtualConta()
        {
            Console.WriteLine("Seu saldo atual é de: R$ " + SaldoAtual.ToString("F2"));
        }*/

        // Método verificador de saldo inicial
        public void SaldoInicial()
        {
            double Saldo = 0.0;
            Console.WriteLine($"Seu saldo atual é de: R$ {Saldo.ToString("F2")} ");
        }

    }
}
