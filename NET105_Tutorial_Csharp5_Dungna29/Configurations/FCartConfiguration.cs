using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model;

namespace NET105_Tutorial_Csharp5_Dungna29.Configurations
{
    public class FCartConfiguration: IEntityTypeConfiguration<FCart>
    {
        public void Configure(EntityTypeBuilder<FCart> builder)
        {

            builder.ToTable("FCarts"); // Tùy chọn tên của bảng
            builder.HasKey(x => x.Id);// Thiết lập FCart.Id là Pk

            builder.Property(x => x.Id).UseIdentityColumn();//FK tự tăng

            //HasOne = Chỉ ra Entity là phía một (bảng FProduct)
            //WithMany = Chỉ ra quan hệ nhiều với bảng Carts
            //HasForeignKey = Chỉ ra cột khóa phụ đặt ở bảng Carts
            builder.HasOne(x => x.FProduct).WithMany(x => x.Carts).HasForeignKey(x => x.ProductId);
        }
    }
}
