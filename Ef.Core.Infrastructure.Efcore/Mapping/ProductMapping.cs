using Ef.DoMain.ProductAgg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef.Core.Infrastructure.Efcore.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>

    {


        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .HasMaxLength(255)
                .IsRequired();
            builder.HasOne(z => z.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.CategoryId);



        }
    }
}
