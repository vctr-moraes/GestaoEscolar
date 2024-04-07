using GestaoEscolar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoEscolar.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(c => c.CargaHoraria)
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(c => c.Descricao)
                .HasColumnType("varchar(300)")
                .IsRequired();

            builder
                .HasMany(c => c.Disciplinas)
                .WithOne(d => d.Curso)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(c => c.Alunos)
                .WithOne(a => a.Curso)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(c => c.Professores)
                .WithOne(p => p.Curso)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Cursos");
        }
    }
}
