namespace Carro
{
    public class Carro
    {
        private string placa;
        public string Placa
        {
            get { return placa; }
            private set
            {
                if (placa != null)
                {
                    throw new Exception("Carro ja possui placa");
                }
                placa = value;
            }
        }

        private string modelo;
        public string Modelo
        {
            get { return modelo; }
            private set
            {
                if (modelo != null)
                {
                    throw new Exception("Carro ja possui modelo");
                }
                modelo = value;
            }
        }

        private Motor motor;
        public Motor Motor
        {
            get { return motor; }
            set
            {
                motor = value;
            }
        }

        private int velocidadeMaxima;
        public int VelocidadeMaxima
        {
            get { return velocidadeMaxima;}
            private set { velocidadeMaxima = value;}
        }

        public Carro(string placa, string modelo, Motor motor) {
        
            this.Placa = placa;
            this.Modelo = modelo;
            if (motor == null)
            {
                throw new Exception("Um carro não pode existir sem motor");
            }
            this.Motor = motor;
            this.Motor.Carro = this;
            calcularVelocidadeMaxima();
        }

        
        public void trocarMotor(Motor motor)
        {
            if (Motor != motor && motor != null)
            {
                if (motor.Carro!= null)
                {
                    throw new Exception("Motor esta sendo ocupado em outro carro");
                }
                Motor.Carro = null;
                Motor = motor;
                motor.Carro = this;
                calcularVelocidadeMaxima();
            }
            else
            {
                throw new Exception("Motor invalido");
            }
        }

        private void calcularVelocidadeMaxima()
        {
            if (Motor.Cilindrada <= 1.0) 
            {
                VelocidadeMaxima = 140;
            }
            if (Motor.Cilindrada > 1.0 && Motor.Cilindrada <= 1.6)
            {
                VelocidadeMaxima = 160;
            }
            if (Motor.Cilindrada > 1.6 && Motor.Cilindrada <= 2.0)
            {
                VelocidadeMaxima = 180;
            }
            if (Motor.Cilindrada > 2.0)
            {
                VelocidadeMaxima = 220;
            }
        }

    }
}