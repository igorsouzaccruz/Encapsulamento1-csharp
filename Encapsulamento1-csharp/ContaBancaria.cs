using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento1_csharp
{
    internal class ContaBancaria
    {
        public string Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(){}

        public ContaBancaria(string conta, string titular)
        {
            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(string conta, string titular, double saldo) : this(conta,titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            
            Saldo -= quantia + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular: "
                + Titular
                + ", Saldo: "
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
