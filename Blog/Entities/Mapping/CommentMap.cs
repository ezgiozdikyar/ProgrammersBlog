using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Entities.Mapping
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(100);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.ModifiedByName).IsRequired();
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.ModifiedDate).IsRequired();
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifiedByName).HasMaxLength(50);
            builder.ToTable("Comments");
        }
    }
}
