﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ClienteModel
    {
        public string Nome;
        public string Cpf;
        public string Rg;
        public string Endereco;        public int Idade { get; set; }
        public bool EhMaiorDeIdade()
        {
            if (this.Idade > 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //	construtor que recebe o nome e a idade
        public void Cliente(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Cpf = "95852158887";
            this.Rg = "383657751";
            this.Endereco = "Rua Três, 680 - Três Lagoas";
            
        }

    }
}
