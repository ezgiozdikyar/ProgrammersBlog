using Blog.Shared.Entities;
using Blog.Shared.Entities.Abstract;

namespace Blog.Entities
{
    public class Role: EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
