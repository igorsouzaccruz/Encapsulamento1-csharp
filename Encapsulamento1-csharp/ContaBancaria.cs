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
        public string Conta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(){}

        public ContaBancaria(string conta, string titular, double saldo)
        {
            Conta = conta;
            Titular = titular;
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
