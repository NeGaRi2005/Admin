using A.Domian.ProductCategorys;
using A.Domian.Products;
using A.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace A.Infrastructure
{
    public  class EFContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public EFContext(DbContextOptions<EFContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ProductCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}


