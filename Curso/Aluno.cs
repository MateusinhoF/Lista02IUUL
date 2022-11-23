using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
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


        private Turma turma;
        public Turma Turma
        {
            get
            {
                return turma;
            }
            set
            {
                turma = value;  
            }
        }

        public Aluno(string nome, Turma turma)
        {

            this.Nome = nome;
            this.Matricula = "Matricula==" + System.Guid.NewGuid().ToString();
            this.Turma = turma;
        }

    }
       
}
