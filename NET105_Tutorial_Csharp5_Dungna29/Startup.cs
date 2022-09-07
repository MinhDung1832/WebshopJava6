using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NET105_Tutorial_Csharp5_Dungna29.DBContextFpoly;


namespace NET105_Tutorial_Csharp5_Dungna29
{
    public class Startup
    {
        /*
         * 1. Khởi tạo Migrations
         *              add-migration MigrationsDungna29
         * 2. Tiến hành cập nhật đối tượng tạo thành bảo vào DB
         *              update-database
         *
         */
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Khai báo chuỗi kết nối (có thể ghi ở appsettings.json)
            services.AddDbContext<DBContextFPOLY>(c => c.UseSqlServer(Configuration.GetConnectionString("ConnectionStringsDungNA29")));
            //Cấu hình đường dẫn cho DBcontext
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Student}/{action=Create}/{id?}");
            });
        }
    }
}
