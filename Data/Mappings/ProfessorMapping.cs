using GestaoEscolar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoEscolar.Data.Mappings
{
    public class ProfessorMapping : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(c => c.Matricula)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(c => c.Cpf)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .HasOne(d => d.Curso)
                .WithMany(c => c.Professores)
                .HasForeignKey(d => d.CursoId);

            builder.ToTable("Professores");
        }
    }
}
