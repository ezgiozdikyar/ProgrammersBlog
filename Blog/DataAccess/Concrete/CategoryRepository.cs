using Blog.DataAccess.Abstract;
using Blog.Entities;
using Blog.Shared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete
{
    public class CategoryRepository : EfEntityRepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
