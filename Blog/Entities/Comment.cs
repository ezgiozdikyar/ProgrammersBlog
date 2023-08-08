using Blog.Shared.Entities;
using Blog.Shared.Entities.Abstract;

namespace Blog.Entities
{
    public class Comment : EntityBase, IEntity
    {
        public string Text { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }

    }
}
