using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using Projeto_Oficial.Models;

namespace Projeto_Oficial
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            string stringConection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BancoProjeto;Integrated Security=True;";
            services.AddDbContext<Context>(options =>
            options.UseSqlServer(stringConection));

            services.AddControllersWithViews()
                .AddRazorRuntimeCompilation()
                .AddNToastNotifyToastr(new ToastrOptions()
                {
                    ProgressBar = true,
                    PositionClass = ToastPositions.TopLeft
                });
        }


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

            app.UseNToastNotify();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
