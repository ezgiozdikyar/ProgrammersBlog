using Blog.Shared.Utilities.Results.ComplexTypes;

namespace Blog.Entities.Dtos
{
    public class CategoryListDto
    {
        public IList<Category> Categories { get; set; }
        public ResultStatus ResultStatus { get; set; }
    }
}
