namespace Progressao
{
    public abstract class Progressao
    {
        private int primeiro;
        public int Primeiro
        {
            get { return primeiro; }
            set { primeiro = value; }
        }

        private int razao;
        public int Razao
        {
            get { return razao; }
            set { razao = value; }
        }

        private int proximoValor;
        public readonly int ProximoValor;

        private List<int> posicoes;
        public List<int> Posicoes
        {
            get { return posicoes; }
            set { posicoes = value; }
        }

        public Progressao(int primeiro, int razao)
        {
            this.Primeiro = primeiro;
            this.Razao = razao;
            this.proximoValor = primeiro;
            this.ProximoValor = proximoValor;
            this.Posicoes = new List<int>();
        }

        public void reinicializar()
        {
            proximoValor = primeiro;
        }

        public abstract int termoAt(int posicao);

        public abstract void calculaProgressao();
    }
}