using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Entities.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.FirstName).IsRequired();
            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.Property(u => u.Username).HasMaxLength(20);
            builder.Property(u => u.FirstName).HasMaxLength(30);
            builder.Property(u => u.LastName).HasMaxLength(30);
            builder.HasIndex(u => u.Email).IsUnique();
            builder.HasIndex(u => u.Username).IsUnique();
            builder.Property(U => U.Username).HasColumnType("VARBINARY(500)");
            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.ModifiedByName).IsRequired();
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.ModifiedDate).IsRequired();
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifiedByName).HasMaxLength(50);
            builder.ToTable("Users");
        }
    }
}
