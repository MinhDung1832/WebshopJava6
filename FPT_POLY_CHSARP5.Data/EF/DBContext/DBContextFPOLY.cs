using System;
using System.Collections.Generic;
using System.Text;
using FPT_POLY_CHSARP5.Data.EF.Configurations;
using FPT_POLY_CHSARP5.Data.EF.Entities;
using FPT_POLY_CHSARP5.Data.Extensions;
using Microsoft.EntityFrameworkCore;

namespace FPT_POLY_CHSARP5.Data.EF
{
    public class DBContextFPOLY : DbContext
    {
        public DBContextFPOLY(DbContextOptions<DBContextFPOLY> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new FCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FOrderConfiguration());
            modelBuilder.ApplyConfiguration(new FOrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new FProductConfiguration());
            modelBuilder.ApplyConfiguration(new FProductInCategoryConfiguration());

            //Data Seeding
            modelBuilder.Seed();//Sau đó tiến hành chạy lại lệnh add-migration +  update-database

        }

        public DbSet<FCategory> FCategories { set; get; }
        public DbSet<FOrder> FOrders { set; get; }
        public DbSet<FOrderDetail> FOrderDetails { set; get; }
        public DbSet<FProduct> FProducts { set; get; }
        public DbSet<FProductInCategory> FProductInCategories { set; get; }
    }
}
