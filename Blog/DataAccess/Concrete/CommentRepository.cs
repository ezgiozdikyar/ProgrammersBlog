using Blog.DataAccess.Abstract;
using Blog.Entities;
using Blog.Shared.Data.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete
{
    public class CommentRepository : EfEntityRepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(DbContext context) : base(context)
        {
        }
    }
}
