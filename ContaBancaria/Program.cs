using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nConta;

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



        }
    }
}
