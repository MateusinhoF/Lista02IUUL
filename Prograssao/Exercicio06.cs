using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressao
{
    public class Exercicio06
    {
        public static void Main(String[] args)
        {
            ProgressaoAritmetica pa = new ProgressaoAritmetica(3, 4);
            ProgressaoGeometrica pg = new ProgressaoGeometrica(3, 4);

            pa.calculaProgressao();
            pg.calculaProgressao();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("PA = "+pa.termoAt(i)+", PG = "+pg.termoAt(i));
            }
        }
    }
}
