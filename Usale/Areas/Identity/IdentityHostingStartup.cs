using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Usale.Areas.Identity.Data;
using Usale.Data;

[assembly: HostingStartup(typeof(Usale.Areas.Identity.IdentityHostingStartup))]
namespace Usale.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UsaleContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UsaleContextConnection")));

                services.AddDefaultIdentity<UsaleUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<UsaleContext>();
            });
        }
    }
}