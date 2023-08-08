using Blog.Entities;
using Blog.Shared.Data.Abstract;

namespace Blog.DataAccess.Abstract
{
    public interface IUserRepository : IEntityRepository<User>
    {
    }
}
