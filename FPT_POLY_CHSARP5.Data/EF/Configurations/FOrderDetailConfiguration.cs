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
    public class FOrderDetailConfiguration : IEntityTypeConfiguration<FOrderDetail>
    {
        public void Configure(EntityTypeBuilder<FOrderDetail> builder)
        {
            builder.ToTable("FOrderDetails");

            builder.HasKey(x => new { x.OrderId, x.ProductId });

            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
