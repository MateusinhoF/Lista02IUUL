using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertidaoDeNascimento
{
    public class CertidaoNascimento
    {
        private DateTime dataEmissao;
        public DateTime DataEmissao
        {
            get { return dataEmissao; }
            private set
            {
                dataEmissao = value;
            }
        }

        private Pessoa pessoa;
        public Pessoa Pessoa
        {
            get { return pessoa; }
            private set
            {
                if (pessoa == null)
                {
                    pessoa = value;
                }
                else
                {
                    throw new Exception("Ja existe uma pessoa vinculada a essa certidão");
                }
            }
        }

        public CertidaoNascimento(Pessoa pessoa) {
            this.Pessoa = pessoa;
            this.DataEmissao = DateTime.Now;
        }
    }
}
