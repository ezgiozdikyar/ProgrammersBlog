using Blog.DataAccess.Abstract;
using Blog.Entities;
using Blog.Shared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete
{
    public class ArticleRepository : EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext context) : base(context)
        {
        }
    }
}
