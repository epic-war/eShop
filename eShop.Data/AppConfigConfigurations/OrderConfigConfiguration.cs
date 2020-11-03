using eShop.Data.Entities;
using eShop.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace eShop.Data.AppConfigConfigurations
{
    public class OrderConfigConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.ShipPhoneNumber).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(OrderStatus.Shipping);
        }
    }
}
