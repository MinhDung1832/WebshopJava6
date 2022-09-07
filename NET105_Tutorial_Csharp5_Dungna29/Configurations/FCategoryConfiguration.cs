using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model.Enums;

namespace NET105_Tutorial_Csharp5_Dungna29.Configurations
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
