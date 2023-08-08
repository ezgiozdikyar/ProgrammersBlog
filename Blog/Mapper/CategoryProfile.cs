using Blog.Entities.Dtos;
using Blog.Entities;
using AutoMapper;

namespace Blog.Mapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile() {
            CreateMap<CategoryAddDto, Category>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<CategoryUpdateDto, Category>().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));
        }
    }
}
