namespace GestaoEscolar.Models
{
    public class Professor : Entity
    {
        protected Professor() { }

        public string? Nome { get; set; }
        public string? Matricula { get; set; }
        public string? Cpf { get; set; }
        public Curso? Curso { get; set; }
        public Guid CursoId { get; set; }
    }
}
