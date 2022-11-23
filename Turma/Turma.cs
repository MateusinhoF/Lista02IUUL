namespace Turma
{
    public class Turma
    {
        List<Aluno> alunos;

        public Turma() {
            alunos = new List<Aluno>();
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
        public void adicionarAluno(Aluno aluno)
        {
            if (existeAluno(aluno))
            {
                throw new Exception("Aluno ja existente");
            }
            else
            {
                alunos.Add(aluno);
            }
        }

        public void removerAluno(Aluno aluno)
        {
            if (!existeAluno(aluno))
            {
                throw new Exception("Aluno não existe");
            }
            else
            {
                alunos.Remove(aluno);
            }
        }

        public void imprimir()
        {
            List<Aluno> alunosOrdenados = alunos.OrderBy(a => a.Nome).ToList();

            foreach (Aluno a in alunosOrdenados)
            {
                Console.WriteLine("Aluno "+a.Nome+" matricula = "+a.Matricula+" nota p1 = "+a.P1+" nota p2 = "+a.P2+" média = "+a.Media);
            }
        }
        public void imprimirEstatisticas()
        {
            double mediaP1 = 0;
            double mediaP2 = 0;
            double mediaGeral = 0;

            foreach (Aluno a in alunos)
            {
                mediaP1 += a.P1;
                mediaP2 += a.P2;
                mediaGeral += a.Media;

            }

            mediaP1 = mediaP1 / alunos.Count();
            mediaP2 = mediaP2 / alunos.Count();
            mediaGeral = mediaGeral / alunos.Count();

            List<Aluno> alunosOrdenados = alunos.OrderByDescending(a => a.Media).ToList();

            Console.WriteLine("Estatísticas: média P1 = "+mediaP1+" média P2 = "+mediaP2+" média turma = "+mediaGeral+" aluno com a maior média = "
                + alunosOrdenados.First().Nome+" matricula = "+ alunosOrdenados.First().Matricula+ " media = "+ alunosOrdenados.First().Media );
        }
    }
}