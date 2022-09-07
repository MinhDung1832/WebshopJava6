using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model;

namespace NET105_Tutorial_Csharp5_Dungna29.Configurations
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
