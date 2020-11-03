using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace eShop.Data.AppConfigConfigurations
{
    public class ProductInCategoryConfigConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductInCategory");
            builder.HasKey(x => new { x.CategoryId, x.Product });
            builder.HasOne(x => x.Product).WithMany(x => x.ProductInCategories).HasForeignKey(x => x.ProcductId);
            builder.HasOne(x => x.Category).WithMany(x => x.ProductInCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}
