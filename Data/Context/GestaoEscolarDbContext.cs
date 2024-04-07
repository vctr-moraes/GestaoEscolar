using GestaoEscolar.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoEscolar.Data.Context
{
    public class GestaoEscolarDbContext : DbContext
    {
        public GestaoEscolarDbContext(DbContextOptions<GestaoEscolarDbContext> options) : base(options) { }

        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Disciplina>? Disciplinas { get; set; }
        public DbSet<Professor>? Professores { get; set; }
        public DbSet<Aluno>? Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(GestaoEscolarDbContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
