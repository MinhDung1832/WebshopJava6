using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FPT_POLY_CHSARP5.Data.EF.DBContext
{
    public class DBContextFactoryFPOLY : IDesignTimeDbContextFactory<DBContextFPOLY>
    {
        public DBContextFPOLY CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("FPTPOLYCHSARP5DUNGNA");
            var optionBuilder = new DbContextOptionsBuilder<DBContextFPOLY>();
            optionBuilder.UseSqlServer(connectionString);
            return new DBContextFPOLY(optionBuilder.Options);

        }
    }
}
