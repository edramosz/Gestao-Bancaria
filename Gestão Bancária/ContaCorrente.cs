using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_Bancária
{
    public class ContaCorrente : Conta
    {
        public int LimiteCredito { get; set; }

        public ContaCorrente(string titular, double saldo, int limiteCredito) :base(titular, saldo)
        {
            LimiteCredito = limiteCredito;
        }

        public bool Sacar(double valor)
        {
            double SaldoCalc = Saldo - valor;
            if(SaldoCalc > 0)
            {
                Console.WriteLine("Saque realizado, limite suficiente!");
                Saldo = Saldo - valor;
                return true;
            }
            else if(SaldoCalc < 0)
            {
                double limite = Saldo + LimiteCredito;
                if(limite >= valor)
                {
                    Console.WriteLine("Saque realizado, limite suficiente!");
                    Saldo = Saldo - valor;
                    return true;
                }
                else if(limite < valor)
                {
                    Console.WriteLine("Saque não realizado, limite insuficiente!");
                    return false;
                }
            }
            return false;
        }
    }
}
