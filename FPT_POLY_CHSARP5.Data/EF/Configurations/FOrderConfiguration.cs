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
    public class FOrderConfiguration : IEntityTypeConfiguration<FOrder>
    {
        public void Configure(EntityTypeBuilder<FOrder> builder)
        {
            builder.ToTable("FOrders");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OrderDate).HasDefaultValue(DateTime.Now);

            builder.Property(x => x.ShipEmail).IsRequired().IsUnicode(false).HasMaxLength(50);

            builder.Property(x => x.ShipAddress).IsRequired().HasMaxLength(200);

            builder.Property(x => x.ShipName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.ShipPhoneNumber).IsRequired().HasMaxLength(200);
        }
    }
}
