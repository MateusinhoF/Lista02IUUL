using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turma
{
    public class Exercicio02
    {
        public static void Main(String[] args) 
        {
            Aluno aluno01 = new Aluno("João","6504651");
            Aluno aluno02 = new Aluno("Clara", "4av530a");
            Aluno aluno03 = new Aluno("Maria", "0dh64f");
            Aluno aluno04 = new Aluno("Cassio", "uu654l");
            Aluno aluno05 = new Aluno("Esse aq vai apagar", "i0oujgda");

            Turma turma = new Turma();

            turma.adicionarAluno(aluno01);
            turma.adicionarAluno(aluno02);
            turma.adicionarAluno(aluno03);
            turma.adicionarAluno(aluno04);
            turma.adicionarAluno(aluno05);

            turma.removerAluno(aluno05);

            aluno01.inserirNotaP1(70);
            aluno01.inserirNotaP2(60);

            aluno02.inserirNotaP1(55);
            aluno02.inserirNotaP2(40);
            
            aluno03.inserirNotaP1(90);
            aluno03.inserirNotaP2(100);
            
            aluno04.inserirNotaP1(60);
            aluno04.inserirNotaP2(60);

            aluno01.calcularMedia();
            aluno02.calcularMedia();
            aluno03.calcularMedia();
            aluno04.calcularMedia();

            Console.WriteLine("Imprimindo alunos");
            turma.imprimir();

            Console.WriteLine("Imprimindo dados estatisticos");
            turma.imprimirEstatisticas();
        }
    }
}
