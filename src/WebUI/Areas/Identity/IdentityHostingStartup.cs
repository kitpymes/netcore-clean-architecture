using System;
using CleanArchitecture.Infrastructure.Identity;
using CleanArchitecture.Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CleanArchitecture.WebUI.Areas.Identity.IdentityHostingStartup))]
namespace CleanArchitecture.WebUI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services
                //    .AddIdentity<ApplicationUser, IdentityRole>(opt =>
                //    {
                //        opt.Password.RequiredLength = 6;
                //        opt.Password.RequireDigit = false;
                //        opt.Password.RequireUppercase = false;

                //        opt.User.RequireUniqueEmail = true;

                //        opt.SignIn.RequireConfirmedEmail = true;
                //    })
                //    .AddEntityFrameworkStores<ApplicationDbContext>()
                //    .AddDefaultTokenProviders();

                //services
                //    .AddDefaultIdentity<ApplicationUser>(opt =>
                //    {
                //        opt.Password.RequiredLength = 6;
                //        opt.Password.RequireDigit = false;
                //        opt.Password.RequireUppercase = false;

                //        opt.User.RequireUniqueEmail = true;

                //        opt.SignIn.RequireConfirmedEmail = true;
                //    })
                //    .AddRoles<IdentityRole>();
                    //.AddEntityFrameworkStores<ApplicationDbContext>();
            });
        }
    }
}