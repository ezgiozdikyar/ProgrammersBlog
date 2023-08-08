using AutoMapper;
using Blog.Entities;
using Blog.Entities.Dtos;

namespace Blog.Mapper
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile() 
        {
            CreateMap<ArticleAddDto, Article>().ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<ArticleUpdateDto, Article>().ForMember(dest => dest.ModifiedDate, opt => opt.MapFrom(src => DateTime.Now));        
        }
    }
}
