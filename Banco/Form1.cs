﻿using System;
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
            c.numero = 1;
            c.Depositar(100.0);
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
            ContaModel contaVictor = new ContaModel();
            contaVictor.titular = "victor";
            contaVictor.numero = 1;
            contaVictor.saldo = 100.0;
            MessageBox.Show(contaVictor.titular);
        }
    }
}