using Ef.Core.Infrastructure.Efcore.Mapping;
using Ef.DoMain.ProductAgg;
using Ef.DoMain.ProductCategory.agg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Core.Infrastructure.Efcore
{
    public class EfContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new ProductMapping());
            //modelBuilder.ApplyConfiguration(new ProductCategoryMapping());

            var assembly = typeof(ProductMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
