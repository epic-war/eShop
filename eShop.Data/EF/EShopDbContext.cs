using eShop.Data.AppConfigConfigurations;
using eShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.EF
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfigConfiguratuion());
            modelBuilder.ApplyConfiguration(new CategoryConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfigConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfigConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfigConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products;
        public DbSet<Category> Categories;
        public DbSet<Cart> Carts;
        public DbSet<CategoryTranslation> CategoryTranslations;
        public DbSet<Contact> Contacts;
        public DbSet<Language> Languages;
        public DbSet<OrderDetail> OrderDetails;
        public DbSet<ProductTranslation> ProductTranslations;
        public DbSet<Promotion> Promotions;
        public DbSet<Transaction> Transactions;
    }
}
