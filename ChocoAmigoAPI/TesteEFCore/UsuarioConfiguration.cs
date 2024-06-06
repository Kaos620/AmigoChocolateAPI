using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TesteEFCore
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("ChocoUsuario");
            builder.HasKey(u => u.UsuarioId);

            //builder
            //    .Property(u => u.UsuarioId)
            //    .UseIdentityColumn()
            //    .HasColumnName("UsuarioId")
            //    .HasColumnType("int");

            builder
                .Property(u => u.NomeUsuario)
                .HasColumnName("NomeUsuario");

            builder
                .Property(u => u.Email)
                .HasColumnName("Email");

            builder
                .Property(u => u.Senha)
                .HasColumnName("Senha");

            builder
                .Property(u => u.Foto)
                .HasColumnName("Foto")
                .IsRequired(false);
        }
    }
}
