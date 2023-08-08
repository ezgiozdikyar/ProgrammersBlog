using Blog.Shared.Utilities.Results.ComplexTypes;

namespace Blog.Entities.Dtos
{
    public class CategoryDto
    {
        public Category Category { get; set; }
        public ResultStatus ResultStatus { get; set; }
    }
}
