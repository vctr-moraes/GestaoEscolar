using GestaoEscolar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoEscolar.Data.Mappings
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
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
                .WithMany(c => c.Alunos)
                .HasForeignKey(d => d.CursoId);

            builder.ToTable("Alunos");
        }
    }
}
