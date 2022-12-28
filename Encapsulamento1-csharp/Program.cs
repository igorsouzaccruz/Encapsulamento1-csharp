using System;
using System.Globalization;
using Encapsulamento1_csharp;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaBancaria;

            Console.Write("Entre o número da conta: ");
            string conta = Console.ReadLine();
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n): ");
            char isDeposito = char.Parse(Console.ReadLine());   
            if(isDeposito == 's')
            {
                Console.Write("Entre com o valor do depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria= new ContaBancaria(conta,titular,deposito);
            }
            else
            {
                contaBancaria = new ContaBancaria(conta, titular);
            }
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Entre com valor de depósito: ");
            contaBancaria.Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);
            Console.WriteLine();

            Console.Write("Entre com valor para saque: ");
            contaBancaria.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);
        }
    }
}