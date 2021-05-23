using A.Application.actions.ProductCategorys;
using A.Application.ProductCategorys;
using A.Domian.ProductCategorys;
using A.Infrastructure.Repositorys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace A.Infrastructure.Core
{
    public class Bootstrapper
    {
        public static void Config (IServiceCollection services, string ConnectionString)
       {
            //services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            //services.AddTransient<IProductCategoryRepository, ProductCategoryRepositorry>();
            //services.AddDbContext<EFContext>(x => x.UseSqlServer(ConnectionString));
      
        }
    }
}
