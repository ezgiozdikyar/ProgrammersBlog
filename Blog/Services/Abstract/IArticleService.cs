using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.Services.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleDto>> Get(int categoryId);
        Task<IDataResult<ArticleListDto>> GetAll();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeleted();
        Task<IDataResult<ArticleListDto>> GetAllByNonDeletedAndActive();
        Task<IDataResult<ArticleListDto>> GetAllByCategory(int categoryId);
        Task<Shared.Utilities.Results.Abstract.IResult> Add(ArticleAddDto articleAddDto, string createdByName);
        Task<Shared.Utilities.Results.Abstract.IResult> Update(ArticleUpdateDto articleUpdateDto, string modifiedByName);
        Task<Shared.Utilities.Results.Abstract.IResult> Delete(int articleId, string modifiedByName);
        Task<Shared.Utilities.Results.Abstract.IResult> HardDelete(int articleId);
    }
}
