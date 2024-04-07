namespace GestaoEscolar.Models
{
    public class Curso : Entity
    {
        protected Curso() { }

        public string? Nome { get; set; }
        public int CargaHoraria { get; set; }
        public string? Descricao { get; set; }
        public List<Disciplina>? Disciplinas { get; set; } = new List<Disciplina>();
        public List<Professor>? Professores { get; set; } = new List<Professor>();
        public List<Aluno>? Alunos { get; set; } = new List<Aluno>();
    }
}
