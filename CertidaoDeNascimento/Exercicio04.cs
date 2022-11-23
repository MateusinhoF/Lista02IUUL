using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertidaoDeNascimento
{
    public class Exercicio04
    {
        public static void Main(String[] args)
        {
            Pessoa pessoa01 = new Pessoa("Jose");
            Pessoa pessoa02 = new Pessoa("Jonas");
            Pessoa pessoa03 = new Pessoa("Jaqueline");

            CertidaoNascimento cartidao01 = new CertidaoNascimento(pessoa01);
            CertidaoNascimento cartidao02 = new CertidaoNascimento(pessoa02);

            pessoa01.Certidao = cartidao01;
            pessoa02.Certidao = cartidao02;

            pessoa01.imprimir();
            pessoa02.imprimir();
            pessoa03.imprimir();
        }
    }
}
