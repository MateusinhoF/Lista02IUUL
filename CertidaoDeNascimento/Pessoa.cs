namespace CertidaoDeNascimento
{
    public class Pessoa
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

        private CertidaoNascimento certidao;
        public CertidaoNascimento Certidao
        {
            get
            {
                return certidao;
            }

            set
            {
                certidao = value;
            }
        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public void adicionarCertidao(CertidaoNascimento certidao)
        {
            if (Certidao == null)
            {
                this.Certidao = certidao;
            }
            else
            {
                throw new Exception("Certidão ja existente");
            }
        }

        public void imprimir()
        {
            if (Certidao!= null)
            {
                Console.WriteLine("Pessoa nome = " + Nome + " Certidao = " + Certidao.DataEmissao);
            }
            else
            {
                Console.WriteLine("Pessoa nome = " + Nome + " não consta certidão");
            }
        }
    }
}