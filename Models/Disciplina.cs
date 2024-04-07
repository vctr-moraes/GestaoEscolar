namespace GestaoEscolar.Models
{
    public class Disciplina : Entity
    {
        protected Disciplina() { }

        public string? Nome { get; set; }
        public Curso? Curso { get; set; }
        public Guid CursoId { get; set; }
    }
}
