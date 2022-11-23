namespace Curso
{
    public class Turma
    {
        private string codigo;
        public string Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
        public List<Aluno> alunos;

        public Turma() {
            this.codigo = "Codigo=="+System.Guid.NewGuid().ToString();
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

        public int quantidadeDeAlunos()
        {
            return alunos.Count;
        }

        public void listarAlunos()
        {
            List<Aluno> alunosOrdenados = alunos.OrderBy(a => a.Nome).ToList();

            foreach (Aluno a in alunosOrdenados)
            {
                Console.WriteLine("Aluno " + a.Nome + " matricula = " + a.Matricula);
            }
        }

    }
}