using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    public class ContaCliente
    {
        public string NumeroConta {get; private set;}
        public string NomeCliente {get; set;}
        public double Saldo {get; private set;}

        // Construtor para o cliente acessar a conta
        public ContaCliente(string numeroConta, string nomeCliente)
        {
            NumeroConta = numeroConta;
            NomeCliente = nomeCliente;
        }

        public ContaCliente(string numeroConta, string nomeCliente, double saldo) : this(numeroConta, nomeCliente)
        {
            Saldo = saldo;
        }

        // Método de Depósito 
        public void Deposito(double valorDeposito)
        {
            Saldo = Saldo + valorDeposito;
            ImprimeDados();
        }

        // Método de Saque e a Cobrança de Taxa de Saque
        public void Saque(double valorDeposito)
        {
            double taxaSaque = 5.00;
            Saldo = Saldo - (valorDeposito + taxaSaque);
            ImprimeDados();
        }

        private void ImprimeDados()
        {
            Console.WriteLine($"Número: {NumeroConta}\nTitular: {NomeCliente}\nSaldo: {Saldo}");
        }
    }
}
