using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma
{
    public class Aluno
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

        private string matricula;
        public string Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            private set
            {
                p1 = value;
            }
        }

        private int p2;
        public int P2
        {
            get
            {
                return p2;
            }
            private set
            {
                p2 = value;
            }
        }

        private double media;
        public double Media
        {
            get
            {
                return media;
            }
            set
            {
                media = value;
            }
        }

        public Aluno(string nome, string matricula) {
        
            this.Nome = nome;
            this.Matricula = matricula;
            this.P1 = 0;
            this.P2 = 0;
            this.Media = 0;
        }

        public void inserirNotaP1(int nota)
        {
            P1 = nota;
        }
        public void inserirNotaP2(int nota)
        {
            P2 = nota;
        }

        public void calcularMedia()
        {
            this.Media = (P1 + P2) / 2;
        }
    }
}
