﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_Bancária
{
    public interface IConta
    {
        void Depositar(double valor);
        bool Sacar(double valor);
        void Transferir(double valor, IConta contaDestino);
        void ExibirInformacoes();
    }
}
