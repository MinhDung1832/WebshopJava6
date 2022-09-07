using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model;

namespace NET105_Tutorial_Csharp5_Dungna29.Configurations
{
    public class FPromotionConfiguration : IEntityTypeConfiguration<FPromotion>
    {
        public void Configure(EntityTypeBuilder<FPromotion> builder)
        {
            builder.ToTable("FPromotions");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired();
        }
    }
}
