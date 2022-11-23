namespace Curso
{
    public class Curso
    {
        private List<Aluno> alunos;
        private List<Turma> turmas;

        public Curso() 
        { 
            alunos = new List<Aluno>();
            turmas = new List<Turma>();
        }

        private bool existeAluno(Aluno aluno)
        {
            foreach (Aluno a in alunos)
            {
                if (a.Equals(aluno))
                {
                    return true;
                }
            }
            return false;
        }

        public void matricularAlunoNoCurso(Aluno aluno)
        {
            if (existeAluno(aluno))
            {
                throw new Exception("Aluno ja matriculado");
            }
            else
            {
                alunos.Add(aluno);
            }
        }

        public void removerAlunoDoCurso(Aluno aluno)
        {
            if (existeAluno(aluno))
            {
                if (aluno.Turma == null)
                {
                    alunos.Remove(aluno);
                }
                else
                {
                    throw new Exception("Aluno está matriculado em uma turma");
                }
            }
            else
            {
                throw new Exception("Aluno não existe");
            }
        }

        private bool existeTurma(Turma turma)
        {
            foreach (Turma t in turmas)
            {
                if (t.Equals(turma))
                {
                    return true;
                }
            }
            return false;
        }

        public void adicionarTurmaNoCurso(Turma turma)
        {
            if (existeTurma(turma))
            {
                throw new Exception("Turma ja existe");
            }
            else
            {
                turmas.Add(turma);
            }
        }

        public void removerTurmaDoCurso(Turma turma)
        {
            if (!existeTurma(turma))
            {
                throw new Exception("Turma não existe");
            }
            else
            {
                if (turma.quantidadeDeAlunos() == 0)
                {
                    turmas.Remove(turma);
                }
            }
        }

        public void listarTurmasEAlunos()
        {
            
            List<Turma> turmasOrdenadas = turmas.OrderBy(t => t.Codigo).ToList();

            turmasOrdenadas.ForEach(t =>
            {
                List<Aluno> alunosOrdenadosDaTurma = t.alunos.OrderBy(a => a.Nome).ToList();

                Console.WriteLine("Turma código = "+t.Codigo);

                alunosOrdenadosDaTurma.ForEach(a => Console.WriteLine("Aluno " + a.Nome + " matricula = " + a.Matricula));
            });

        }
    }
}