using ChocoAmigoAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ChocoAmigo.Repository.EntityFramework.Configurations.Entities
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("ChocoUsuario");
            builder.HasKey(u => u.UsuarioId);

            builder
                .Property(u => u.UsuarioId)
                .UseIdentityColumn()
                .HasColumnName("UsuarioId")
                .HasColumnType("int");

            builder
                .Property(u => u.NomeUsuario)
                .HasColumnName("NomeUsuario")
                .HasColumnType("varchar(60)");

            builder
                .Property(u => u.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(100)");

            builder
                .Property(u => u.Senha)
                .HasColumnName("Senha")
                .HasColumnType("varchar(30)");

            builder
                .Property(u => u.Foto)
                .HasColumnName("Foto")
                .HasColumnType("varchar(max)");
        }
    }
}
