using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    public class Exercicio05
    {
        public static void Main(String[] args)
        {
            Motor motor01 = new Motor(5.0);
            Motor motor02 = new Motor(1.0);
            Motor motor03 = new Motor(1.4);
            Motor motor04 = new Motor(1.6);
            Motor motor05 = new Motor(1.8);
            Motor motor06 = new Motor(2.0);

            Carro carro01 = new Carro("abc", "Hummer", motor01);
            Carro carro02 = new Carro("hjh", "Celta", motor02);
            Carro carro03 = new Carro("nbv", "Corolla", motor03);
            Carro carro04 = new Carro("kti", "350z", motor04);
            Carro carro05 = new Carro("rwq", "rx7", motor05);
            Console.WriteLine("Carros e motores adicionados");
            try
            {
                Console.WriteLine("Alterando o motor do celta carro 02 para motor 2.0");
                carro02.trocarMotor(motor06);
                Console.WriteLine("Alterando o motor do celta carro 02 para motor 1.6");
                carro02.trocarMotor(motor04);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Carro placa " + carro01.Placa + " modelo " + carro01.Modelo + " motor " + carro01.Motor.Cilindrada);
            Console.WriteLine("Carro placa " + carro02.Placa + " modelo " + carro02.Modelo + " motor " + carro02.Motor.Cilindrada);
            Console.WriteLine("Carro placa " + carro03.Placa + " modelo " + carro03.Modelo + " motor " + carro03.Motor.Cilindrada);
            Console.WriteLine("Carro placa " + carro04.Placa + " modelo " + carro04.Modelo + " motor " + carro04.Motor.Cilindrada);
            Console.WriteLine("Carro placa " + carro05.Placa + " modelo " + carro05.Modelo + " motor " + carro05.Motor.Cilindrada);
            Console.WriteLine("Motor " + motor02.Cilindrada + " carro " + motor02.Carro);

        }
    }
}
