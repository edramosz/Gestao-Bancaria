using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_Bancária
{
    public class Conta : IConta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Titular: " + Titular + " Saldo: " + Saldo);
        }

        public bool Sacar(double valor)
        {
            double SaldoCalc = Saldo - valor;
            if (SaldoCalc < 0)
            {
                Saldo = Saldo - valor;
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Transferir(double valor, IConta contaDestino)
        {
            double SaldoCalc = Saldo - valor;
            if(SaldoCalc > 0)
            {
                contaDestino.Depositar(valor);
            }
            else if(SaldoCalc < 0)
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
    }
}
