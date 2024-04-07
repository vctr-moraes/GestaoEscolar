using GestaoEscolar.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoEscolar.Data.Mappings
{
    public class DisciplinaMapping : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .HasOne(d => d.Curso)
                .WithMany(c => c.Disciplinas)
                .HasForeignKey(d => d.CursoId);

            builder.ToTable("Disciplinas");
        }
    }
}
