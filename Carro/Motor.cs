using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    public class Motor
    {
        private double cilindrada;
        public double Cilindrada
        {
            get
            {
                return cilindrada;
            }
            private set
            {
                if (cilindrada != 0) {
                    throw new Exception("Motor ja possui cilindrada");
                }
                cilindrada = value;
            }
        }
        private Carro carro;
        public Carro Carro
        {
            get
            {
                if (carro == null)
                {
                    return null;
                }
                return carro;
            }
            set
            {
                carro = value;
            }
        }
        public Motor(double cilindrada) {
            if (cilindrada == null)
            {
                throw new Exception("Um motor precisa de sua cilindrada");
            }
            this.Cilindrada = cilindrada;
        }

        
    }
}
