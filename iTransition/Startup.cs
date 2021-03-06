using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iTransition.Classes;
using iTransition.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace iTransition
{
    public class Startup
    {
        /*public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }*/
        //IConfiguration Configuration { get; }


       public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DBContext>();
            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DBContext>();
            services.AddControllersWithViews();
            services.AddScoped<DBLogic>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name : "default",
                    pattern : "{controller=Account}/{action=Register}/{id?}"
                    );
            });
        }
    }
}
