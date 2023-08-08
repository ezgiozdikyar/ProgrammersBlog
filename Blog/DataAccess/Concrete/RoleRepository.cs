using Blog.DataAccess.Abstract;
using Blog.Entities;
using Blog.Shared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete
{
    public class RoleRepository : EfEntityRepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(DbContext context) : base(context)
        {
        }
    }
}
