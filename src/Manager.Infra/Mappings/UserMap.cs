using Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("BIGINT");

            builder.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(80)
                .HasColumnName("name")
                .HasColumnType("VARCHAR(80)");
            
            builder.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("password")
                .HasColumnType("VARCHAR(30)");

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(180)
                .HasColumnName("email")
                .HasColumnType("VARCHAR(180)");


        }
    }
}

