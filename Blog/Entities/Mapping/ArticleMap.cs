using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Entities.Mapping
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();
            builder.Property(a => a.Title).HasMaxLength(100); ;
            builder.Property(a => a.Title).IsRequired(true);
            builder.Property(a => a.Content).IsRequired(true);
            builder.Property(a => a.Date).IsRequired(true);
            builder.Property(a => a.SeoAuthor).IsRequired(true);
            builder.Property(a => a.SeoDescription).IsRequired(true);
            builder.Property(a => a.SeoTags).IsRequired(true);
            builder.Property(a => a.ViewsCount).IsRequired(true);
            builder.Property(a => a.CommentsCount).IsRequired(true);
            builder.Property(a => a.Thumbnail).IsRequired(true);
            builder.Property(a => a.SeoDescription).HasMaxLength(150);
            builder.Property(a => a.SeoTags).HasMaxLength(70);
            builder.Property(a => a.Thumbnail).HasMaxLength(250);
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.HasOne<Category>(a => a.Category).WithMany(c=>c.Articles).HasForeignKey(a => a.CategoryId);
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.ModifiedByName).IsRequired();
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.ModifiedDate).IsRequired();
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifiedByName).HasMaxLength(50);
            builder.ToTable("Articles");
        }
    }
}
