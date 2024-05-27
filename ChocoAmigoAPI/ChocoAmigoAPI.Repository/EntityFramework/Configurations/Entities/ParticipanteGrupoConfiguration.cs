using ChocoAmigoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChocoAmigo.Repository.EntityFramework.Configurations.Entities
{
    public class ParticipanteGrupoConfiguration : IEntityTypeConfiguration<ParticipanteGrupo>
    {
        public void Configure(EntityTypeBuilder<ParticipanteGrupo> builder)
        {
            builder.ToTable("ChocoParticipanteGrupo");
            builder.HasKey(f => f.ParticipantesGrupoId);

            builder
                .Property(f => f.ParticipantesGrupoId)
                .UseIdentityColumn()
                .HasColumnName("ParticipantesGrupoId")
                .HasColumnType("int");

            builder
                .Property(f => f.GrupoId)
                .HasColumnName("GrupoId")
                .HasColumnType("int");

            builder
                .HasOne(f => f.Grupo)
                .WithMany()
                .HasForeignKey(f => f.GrupoId);

            builder
                .Property(f => f.UsuarioId)
                .HasColumnName("UsuarioId")
                .HasColumnType("int");

            builder
                .HasOne(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.UsuarioId);
        }
    }
}
