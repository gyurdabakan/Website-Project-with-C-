using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WebSiteProject.Entity.Entities;

namespace WebSiteProject.Persistance.Contexts
{
	public class BaseDBContext : DbContext
	
	{//Burası kalıp böyle kullanılır.

        public IConfiguration Configuration { get; set; }
        public DbSet<Articles> Articles { get; set; }



		public BaseDBContext(DbContextOptions contextOptions) :base(contextOptions)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)//Modelleri database  de nasıl oluşturacağıma karar vericem.
        {//bunun adı fluent api
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//
        }

    }

    public class YourDbContextFactory : IDesignTimeDbContextFactory<BaseDBContext>
	{
	public BaseDBContext CreateDbContext(string[] args)
		{ var optionsBuilder = new DbContextOptionsBuilder<BaseDBContext>();
			optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=WebsiteExample;Persist Security Info=True;User ID=SA;Password=reallyStrongPwd123;MultipleActiveResultSets=True;TrustServerCertificate=True;");
			return new BaseDBContext(optionsBuilder.Options); }
	}
}

