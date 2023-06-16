using System;
using Microsoft.Extensions.DependencyInjection;
using WebSiteProject.Core.Managers;
using WebSiteProject.Core.Services;

namespace WebSiteProject.Core
{
	public static class CoreServiceRegistiration
	{
		public static IServiceCollection AddCoreServices(this IServiceCollection services)
		{
			services.AddScoped<IArticleService, ArticleManager>();

			return services;
		}

	}
}

