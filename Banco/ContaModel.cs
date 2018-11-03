using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaModel
    {
        
        public ClienteModel titular { get; set; }
        public double saldo { get; private set; }

        private int numero { get; set; }
        public int Numero // este é uma property
        {
            get //leitura
            {
                return this.numero;
            }
            set //gravação
            {
                this.numero = value;
            }
        }

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
        }        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.saldo += valor;
            }
            
        }        

        public void Transferir(double valor, ContaModel contaDestino)
        {
            if (this.Sacar(valor))
            {
                contaDestino.Depositar(valor);
            }
        }        public double ObterSaldo()
        {
            return this.saldo;
        }        public void DefinirNumero(int numero)
        {
            this.numero = numero;
        }
    }
}
