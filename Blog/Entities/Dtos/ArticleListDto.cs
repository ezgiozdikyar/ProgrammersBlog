using Blog.Shared.Utilities.Results.ComplexTypes;

namespace Blog.Entities.Dtos
{
    public class ArticleListDto
    {
        public IList<Article> Articles { get; set; }
        public ResultStatus ResultStatus { get; set; }
    }
}
