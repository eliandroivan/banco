﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaModel
    {
        public int numero;
        public string titular;
        public double saldo = 020;

        public bool Sacar(double valor)
        {
            if ((this.saldo >= valor) && (valor > 0))
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
            
        }
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
            }
        }
    }
}