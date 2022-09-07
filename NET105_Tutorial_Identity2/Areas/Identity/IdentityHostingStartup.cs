using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET105_Tutorial_Identity2.Areas.Identity.Data;
using NET105_Tutorial_Identity2.Data;

[assembly: HostingStartup(typeof(NET105_Tutorial_Identity2.Areas.Identity.IdentityHostingStartup))]
namespace NET105_Tutorial_Identity2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DungnaAuthContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DungnaAuthContextConnection")));

                //Code giống dưới đây
                services.AddDefaultIdentity<ApplicationUser>(options =>
                    {
                        options.SignIn.RequireConfirmedAccount = true;
                        options.Password.RequireLowercase = false;
                        options.Password.RequireUppercase = false;
                    })
                    .AddEntityFrameworkStores<DungnaAuthContext>();
            });
        }
    }
}