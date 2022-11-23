using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    public class Exercicio03
    {
        public static void Main(String[] args)
        {

            Curso curso = new Curso();

            Turma turma01 = new Turma();
            Turma turma02 = new Turma();
            Turma turma03 = new Turma();


            Aluno aluno01 = new Aluno("João",turma01);
            Aluno aluno02 = new Aluno("Clara", turma01);
            Aluno aluno03 = new Aluno("Maria", turma02);
            Aluno aluno04 = new Aluno("Cassio", turma02);
            Aluno aluno05 = new Aluno("Adalberto", turma03);
            Aluno aluno06 = new Aluno("Francine", turma03);

            try
            {
                Console.WriteLine("adicionando turmas no curso");
                curso.adicionarTurmaNoCurso(turma01);
                curso.adicionarTurmaNoCurso(turma02);
                curso.adicionarTurmaNoCurso(turma03);

                Console.WriteLine("adicionando alunos no curso");
                curso.matricularAlunoNoCurso(aluno01);
                curso.matricularAlunoNoCurso(aluno02);
                curso.matricularAlunoNoCurso(aluno03);
                curso.matricularAlunoNoCurso(aluno04);
                curso.matricularAlunoNoCurso(aluno05);
                curso.matricularAlunoNoCurso(aluno06);

                Console.WriteLine("adicionando alunos nas turmas");
                turma01.adicionarAluno(aluno01);
                turma01.adicionarAluno(aluno02);
                turma02.adicionarAluno(aluno03);
                turma02.adicionarAluno(aluno04);
                turma03.adicionarAluno(aluno05);
                turma03.adicionarAluno(aluno06);


                Console.WriteLine("aluno 1 saindo da turma 01");
                turma01.removerAluno(aluno01);
                aluno01.Turma = null;

                Console.WriteLine("aluno 2 trocando da turma 01 para turma 2");
                turma01.removerAluno(aluno02);
                aluno02.Turma = turma02;
                turma02.adicionarAluno(aluno02);

                Console.WriteLine("turma 3 removendo aluno 5");
                turma03.removerAluno(aluno05);
                aluno05.Turma = null;

                Console.WriteLine("removendo turma 1 do curso");
                curso.removerTurmaDoCurso(turma01);

                Console.WriteLine("removendo aluno 1 do curso");
                curso.removerAlunoDoCurso(aluno01);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Listando alunos da turma 01");
            turma01.listarAlunos();

            Console.WriteLine("Listando alunos da turma 02");
            turma02.listarAlunos();

            Console.WriteLine("Listando alunos da turma 03");
            turma03.listarAlunos();

            Console.WriteLine("Listando turmas e alunos do curso");
            curso.listarTurmasEAlunos();
        }
    }
}
