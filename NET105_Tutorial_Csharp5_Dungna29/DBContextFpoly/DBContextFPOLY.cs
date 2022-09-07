using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NET105_Tutorial_Csharp5_Dungna29.Configurations;
using NET105_Tutorial_Csharp5_Dungna29.Models;
using NET105_Tutorial_Csharp5_Dungna29.Models.Convention;
using NET105_Tutorial_Csharp5_Dungna29.Models.FluentApi_Model;

namespace NET105_Tutorial_Csharp5_Dungna29.DBContextFpoly
{
    public class DBContextFPOLY:DbContext
    {
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            builder.AddConsole();
        });

        #region DbSet Convention
        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Color> Colors { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Student1> Student1s { set; get; }
        public DbSet<Grade1> Grade1s { set; get; }
        public DbSet<Student2> Student2s { set; get; }
        public DbSet<Grade2> Grade2s { set; get; }
        public DbSet<Student3> Student3s { set; get; }
        public DbSet<Grade3> Grade3s { set; get; }
        public DbSet<Student4> Student4s { set; get; }
        public DbSet<Grade4> Grade4s { set; get; }
        public DbSet<Student> Students { set; get; }
        public DbSet<StudentAddress> StudentAddress { set; get; }

        #endregion

        #region DbSet Fluent Api

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FCartConfiguration());
            modelBuilder.ApplyConfiguration(new FCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FCategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new FContactConfiguration());
            modelBuilder.ApplyConfiguration(new FLanguageConfiguration());
            modelBuilder.ApplyConfiguration(new FOrderConfiguration());
            modelBuilder.ApplyConfiguration(new FOrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new FProductConfiguration());
            modelBuilder.ApplyConfiguration(new FProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new FProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new FPromotionConfiguration());
            modelBuilder.ApplyConfiguration(new FTransactionConfiguration());
        }

        public DbSet<FCart> FCarts { set; get; }
        public DbSet<FCategory> FCategories { set; get; }
        public DbSet<FCategoryTranslation> FCategoryTranslations { set; get; }
        public DbSet<FContact> FContacts { set; get; }
        public DbSet<FLanguage> FLanguages { set; get; }
        public DbSet<FOrder> FOrders { set; get; }
        public DbSet<FOrderDetail> FOrderDetails { set; get; }
        public DbSet<FProduct> FProducts { set; get; }
        public DbSet<FProductInCategory> FProductInCategories { set; get; }
        public DbSet<FProductTranslation> FProductTranslations { set; get; }
        public DbSet<FPromotion> FPromotions { set; get; }
        public DbSet<FTransaction> FTransactions { set; get; }


        #endregion
        public DBContextFPOLY(DbContextOptions<DBContextFPOLY> options)
            : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(loggerFactory); // thiết lập logging
        }


    }
}
