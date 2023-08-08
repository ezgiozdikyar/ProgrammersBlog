using Blog.Entities;
using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Results.Abstract;

namespace Blog.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IDataResult<CategoryDto>> Get(int categoryId);
        Task<IDataResult<CategoryListDto>> GetAll();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeleted();
        Task<IDataResult<CategoryListDto>> GetAllByNonDeletedAndActive();
        Task<Shared.Utilities.Results.Abstract.IResult> Add(CategoryAddDto categoryAddDto, string createdByName);
        Task<Shared.Utilities.Results.Abstract.IResult> Update(CategoryUpdateDto categoryUpdateDto, string modifiedByName);
        Task<Shared.Utilities.Results.Abstract.IResult> Delete(int categoryId, string modifiedByName);
        Task<Shared.Utilities.Results.Abstract.IResult> HardDelete(int categoryId);
    }
}
