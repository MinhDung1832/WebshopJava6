using System;
using System.Collections.Generic;
using System.Text;
using FPT_POLY_CHSARP5.Data.EF.Entities;
using FPT_POLY_CHSARP5.Data.EF.Entities.Enums;
using Microsoft.EntityFrameworkCore;

namespace FPT_POLY_CHSARP5.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Lưu ý bắt buộc phải triển khai có ID vì nó cần đảm bảo vẹn toàn khi có các khóa phụ ở các bảng khác
            modelBuilder.Entity<FProduct>().HasData(
                new FProduct() { Id = 1, Price = 50000, OriginalPrice = 30000, Stock = 150, ViewCount = 500, DateCreated = DateTime.Now, SeoAlias = "Dungna1" },
                new FProduct() { Id = 2, Price = 900000, OriginalPrice = 50000, Stock = 150, ViewCount = 600, DateCreated = DateTime.Now, SeoAlias = "Dungna2"}

            );
            modelBuilder.Entity<FCategory>().HasData(
                new FCategory()
                {
                    Id = 1,
                    SortOrder = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    Status = Status.Active
                });

            modelBuilder.Entity<FProductInCategory>().HasData(
                new FProductInCategory(){ProductId = 1,CategoryId = 1}, 
                new FProductInCategory(){ProductId = 2,CategoryId = 1}
               );
        }
    }
}
