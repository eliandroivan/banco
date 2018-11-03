using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaModel c = new ContaModel();
            c.Numero = 1;
            c.Depositar(100.0);            MessageBox.Show(c.saldo.ToString());
            //	inicializa	os	atributos
            //	Se	a	conta	tiver	saldo	suficiente,	deuCerto	conterá	o	valor	true
            //	senão,	ela	conterá	false
            //bool deuCerto = c.Sacar(100.0);
            //if (deuCerto)
            //{
            //    MessageBox.Show("Saque realizado com sucesso");
            //    MessageBox.Show(c.saldo.ToString());
            //}
            //else
            //{
            //    MessageBox.Show("Saldo Insuficiente");
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ClienteModel victor = new ClienteModel();
            //victor.nome = "victor";

            //ContaModel contaVictor = new ContaModel();
            //contaVictor.titular = victor;
            //contaVictor.numero = 1;
            //contaVictor.saldo = 100.0;
            //MessageBox.Show(contaVictor.titular.nome);



            //ContaModel conta = new ContaModel();
            //ClienteModel cliente = new ClienteModel();
            //conta.titular = cliente;
            //conta.titular.nome = "alberto";


            ContaModel umaConta = new ContaModel();
            ClienteModel guilherme = new ClienteModel();
            guilherme.Rg = "12345678-9";
            umaConta.titular = guilherme;
            umaConta.titular.Rg = "98765432-1";
            MessageBox.Show(guilherme.Rg);
        }
    }
}