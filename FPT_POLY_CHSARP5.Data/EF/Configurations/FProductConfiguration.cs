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
    public class FProductConfiguration : IEntityTypeConfiguration<FProduct>
    {
        public void Configure(EntityTypeBuilder<FProduct> builder)
        {
            builder.ToTable("FProducts");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();


            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.OriginalPrice).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
        }
    }
}
