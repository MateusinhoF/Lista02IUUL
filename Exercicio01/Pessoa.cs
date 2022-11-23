using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    internal class Pessoa
    {
        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        private long cpf;
        public long Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                dataNascimento = value;
            }
        }

        private float rendaMensal;
        public float RendaMensal {
            get
            {
                return rendaMensal;
            }
            set
            {
                rendaMensal = value;
            }
        }

        private char estadoCivil;
        public char EstadoCivil
        {
            get
            {
                return estadoCivil;
            }
            set
            {
                estadoCivil = value;
            }
        }

        private int dependentes;
        public int Dependentes
        {
            get
            {
                return dependentes;
            }
            set
            {
                dependentes = value;
            }
        }

        public Pessoa(string nome, long cpf, DateTime dataNascimento, float rendaMensal, char estadoCivil, int dependentes)
        {
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            RendaMensal = rendaMensal;
            EstadoCivil = estadoCivil;
            Dependentes = dependentes;
        }

        public void imprimirPessoa()
        {
            Console.WriteLine("*************Imprimindo Pessoa*************\n" +
                "Nome = "+this.Nome+"\n" +
                "CPF = "+this.Cpf+"\n" +
                "Data de Nascimento = "+this.DataNascimento+"\n" +
                "Renda Mensal = "+this.RendaMensal.ToString("C")+"\n" +
                "Estado Civil = "+this.EstadoCivil.ToString().ToUpper()+"\n" +
                "Dependentes = "+this.Dependentes);
        }
    }
}
