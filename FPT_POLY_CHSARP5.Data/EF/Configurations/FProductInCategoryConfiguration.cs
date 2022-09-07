using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FPT_POLY_CHSARP5.Data.EF.Entities;
using FPT_POLY_CHSARP5.Data.EF.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FPT_POLY_CHSARP5.Data.EF.Configurations
{
    public class FProductInCategoryConfiguration : IEntityTypeConfiguration<FProductInCategory>
    {
        public void Configure(EntityTypeBuilder<FProductInCategory> builder)
        {
            builder.HasKey(t => new { t.CategoryId, t.ProductId });

            builder.ToTable("FProductInCategories");

            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(t => t.Category).WithMany(pc => pc.ProductInCategories)
                .HasForeignKey(pc => pc.CategoryId);
        }
    }
}
