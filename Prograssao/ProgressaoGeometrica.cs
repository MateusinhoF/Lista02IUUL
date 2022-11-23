using Progressao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressao
{
    public class ProgressaoGeometrica : Progressao
    {

        public int proximoValor;

        public ProgressaoGeometrica(int primeiro, int razao)
            :base(primeiro, razao)
        {

        }

        public override int termoAt(int posicao)
        {
            return Posicoes[posicao];
        }

        public override void calculaProgressao()
        {
            Posicoes.Add(Primeiro);
            int progressao = Primeiro;
            for (int i = 1; i < 10; i++)
            {
                progressao = progressao * Razao;
                Posicoes.Add(progressao);
            }
        }
    }
}
