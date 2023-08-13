using Blog.DataAccess.Abstract;
using Blog.DataAccess.Concrete;
using Blog.Entities.Contexts;
using Blog.Services.Abstract;
using Blog.Services.Concrete;

namespace Blog.Services.Extensions
{
    public static class ServiceCollentionExtentions
    {
        public static IServiceCollection LoadServices(this IServiceCollection services)
        {
            services.AddDbContext<BlogContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<IArticleService,ArticleManager>();
            return services;
        }
    }
}
