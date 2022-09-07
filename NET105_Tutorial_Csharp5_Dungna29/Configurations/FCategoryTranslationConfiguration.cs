using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model;

namespace NET105_Tutorial_Csharp5_Dungna29.Configurations
{
    public class FCategoryTranslationConfiguration:IEntityTypeConfiguration<FCategoryTranslation>
    {
        public void Configure(EntityTypeBuilder<FCategoryTranslation> builder)
        {
            builder.ToTable("FCategoryTranslations");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            //Property chỉ ra cách làm việc với các thuộc tính định cấu hình
            //IsRequired Chỉ ra thuộc tính của cột được phép null hoặc không null
            //HasMaxLength Chỉ ra độ dài của thuộc tính
            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            //IsUnicode chỉ ra thuộc tính chuỗi có thể chứa ký tự unicode hoặc không
            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.CategoryTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Category).WithMany(x => x.CategoryTranslations).HasForeignKey(x => x.CategoryId);
        }
    }
}
