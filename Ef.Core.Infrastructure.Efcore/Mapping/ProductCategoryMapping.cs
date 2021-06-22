using Ef.DoMain.ProductCategory.agg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ef.Core.Infrastructure.Efcore.Mapping
{
    public class ProductCategoryMapping : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();
            builder.HasMany(x => x.Products)
                .WithOne(x => x.Category)
                .HasForeignKey(c => c.CategoryId);

        }
    }
}
