using System;
using Encapsulamento1_csharp;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            conta.Conta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            conta.Titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char isDeposito = char.Parse(Console.ReadLine());   
            if(isDeposito == 's')
            {
                Console.Write("Entre com o valor do depósito: ");
                conta.Saldo = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine(conta);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com valor de depósito: ");
            conta.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com valor para saque: ");
            conta.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}