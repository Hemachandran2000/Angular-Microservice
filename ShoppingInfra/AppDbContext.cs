using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using ShoppingCartEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingInfra
{ 
    public class AppDbContext: DbContext
    {
        Seedproducts _seedProducts = new Seedproducts();
        SeedUsers _seedUsers = new SeedUsers();

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) {  } 

        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CategoryModel> Category { get; set; }

        public DbSet<SubCategoryModel> SubCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductsModel>().HasData(_seedProducts._products);

            builder.Entity<UserModel>().HasData(_seedUsers._users);
        }
    }
}
