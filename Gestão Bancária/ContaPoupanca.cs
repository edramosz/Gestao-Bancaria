using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_Bancária
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }
        public ContaPoupanca(string titular, double saldo, double taxaJuros):base(titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor + (valor * TaxaJuros);
        }
    }
}
