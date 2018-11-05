using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaModel
    {
        
        public ClienteModel titular { get; set; }
        private double saldo { get; set; }

        private int numero { get; set; }
        public int Numero // este é uma property
        {
            get //leitura
            {
                return this.numero;
            }
            set //gravação
            {
                //this.numero = value;
                Random numAleatorio = new Random();
                this.numero = numAleatorio.Next(1, 999);
            }
        }

        

        public bool Sacar(double valor)
        {
            if ((this.saldo >= valor) && (valor > 1))
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Depositar(double valor)
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

        }

        public double ObterSaldo()
        {
            return this.saldo;
        }


        public void DefinirNumero()
        {
            //this.numero = numero;
            Random numAleatorio = new Random();
            this.numero = numAleatorio.Next(0,999);
        }
    }
}
