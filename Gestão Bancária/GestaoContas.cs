using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_Bancária
{
    public class GestaoContas
    {
        List<IConta> Contas = new List<IConta>();

        public void Adicionar(Conta conta)
        {
            Contas.Add(conta);
        }
        public void Listar()
        {
            foreach(Conta c in Contas)
            {
                Console.WriteLine("Titular: " + c.Titular + " Saldo: " + c.Saldo);
            }
        }
    }
}
