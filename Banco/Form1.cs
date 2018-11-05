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
        private ContaModel conta;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Depositar(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.conta.ObterSaldo());
           

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = txtValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            conta.Sacar(valorOperacao);
            txtSaldo.Text = Convert.ToString(this.conta.ObterSaldo());

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


            //ContaModel umaConta = new ContaModel();
            //ClienteModel cliente = new ClienteModel();
            //umaConta.DefinirNumero();
            //MessageBox.Show(umaConta.Numero.ToString());

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.conta = new ContaModel();
            ClienteModel novoCliente = new ClienteModel("andré gonzales", 44);
            conta.titular = novoCliente;
            conta.DefinirNumero();
            txtTitular.Text = conta.titular.Nome;
            txtNumero.Text = Convert.ToString(conta.Numero);
            txtSaldo.Text = Convert.ToString(conta.ObterSaldo());
            


        }

        
    }
}