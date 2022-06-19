using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SocialMedia_Core.Entities;

namespace SocialMedia_Infraestructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(e => e.UserId);
            builder.Property(e => e.UserId)
            .HasColumnName("IdUsuario");
            builder.Property(e => e.Name)
            .HasColumnName("Nombres")
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            builder.Property(e => e.LastName)
            .HasColumnName("Apellidos")
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
            builder.Property(e => e.Email)
            .HasColumnName("Email")
            .IsRequired()
            .HasMaxLength(100)
            .IsUnicode(false);
            builder.Property(e => e.DateOfBith)
            .HasColumnName("FechaNacimiento")
            .HasColumnType("date");
            builder.Property(e => e.CellPhone)
            .HasColumnName("Telefono")
            .HasMaxLength(10)
            .IsUnicode(false);
            builder.Property(e => e.IsActive)
            .HasColumnName("Activo");
        }
    }
}
