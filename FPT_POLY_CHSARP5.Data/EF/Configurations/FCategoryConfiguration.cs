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
    public class FCategoryConfiguration : IEntityTypeConfiguration<FCategory>
    {
        public void Configure(EntityTypeBuilder<FCategory> builder)
        {
            builder.ToTable("FCategories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            //HasDefaultValue = Chỉ ra cấu hình mặc định cho cột được ánh xạ với class Enum Status
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
