using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Entities.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.Name).HasMaxLength(70);
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.ModifiedByName).IsRequired();
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.ModifiedDate).IsRequired();
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifiedByName).HasMaxLength(50);
            builder.ToTable("Categories");
        }
    }
}
