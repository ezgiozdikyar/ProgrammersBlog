using Blog.Entities.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Blog.Entities.Contexts
{
    public class BlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(@"Data Source=\DESKTOP-08QVV4V\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //optionsBuilder.UseSqlServer(@"Server=(localdb)\SQLEXPRESS;Database=Blog;Trusted_Connection=True");
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-08QVV4V\SQLEXPRESS;Database=your_database_name;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
        }
    }
}
