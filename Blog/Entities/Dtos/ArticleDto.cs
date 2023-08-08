using Blog.Shared.Utilities.Results.ComplexTypes;

namespace Blog.Entities.Dtos
{
    public class ArticleDto
    {
        public Article Article { get; set; }
        public ResultStatus ResultStatus { get; set; }
    }
}
