using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebSiteProject.Persistance.Abstract;
using WebSiteProject.Persistance.Concreate;
using WebSiteProject.Persistance.Contexts;

namespace WebSiteProject.Persistance
{
	public static class PersistanceServiceRegistiration
	{
		public static IServiceCollection AddpersistanceServices(this IServiceCollection services , IConfiguration configuration)//IServiceCollectionun önüne this eklediğimiz zaman extention method yazmam lazım
			//interfacedeki yetenekler yeterli değil extention sayesinde yetenek ekliyoruz
		{
			services.AddDbContext<BaseDBContext>(options => {
                options.UseSqlServer(
					configuration.GetConnectionString("MyWebSiteConnectionString"));
            });//SQL Server bağlantısını yapıcaz


			services.AddScoped<IArticleRepository, ArticleRepository>();
			services.AddScoped<ICategoryRepository, CategoryRepository>();
			//services.AddSingleton<>araştır farklarını 
			//services.AddTransient<>
			return services;
		}

	}
}

