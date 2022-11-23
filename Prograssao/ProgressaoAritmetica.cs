using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressao
{
    public class ProgressaoAritmetica : Progressao
    {
        public int proximoValor;

        public ProgressaoAritmetica(int primeiro, int razao)
            :base(primeiro, razao)
        { }

        public override int termoAt(int posicao)
        {
            return Posicoes[posicao];
        }

        public override void calculaProgressao()
        {
            Posicoes.Add(Primeiro);
            int progressao = Primeiro;
            for (int i = 1; i < 10; i++) {
                progressao += Razao;
                Posicoes.Add(progressao);
            }
        }
    }
}
