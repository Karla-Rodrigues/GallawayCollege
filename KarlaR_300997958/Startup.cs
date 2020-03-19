using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.DependencyInjection;
using KarlaR_300997958.Models;
using System.Web.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Identity;

namespace KarlaR_300997958
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>  /*constructor*/
            Configuration = configuration;
        public IConfiguration Configuration { get; } /*public property*/

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:FacultyManagementFaculty:ConnectionString"]));

            services.AddDbContext<AppIdentityDbContext>(options =>
                options.UseSqlServer(
                    Configuration["Data:FacultyManagementIdentity:ConnectionString"]));

            services.AddIdentity<IdentityUser, IdentityRole>()
                    .AddEntityFrameworkStores<AppIdentityDbContext>()
                    .AddDefaultTokenProviders();

            services.AddTransient<IFacultyRepository, EFFacultyRepository>();
            services.AddTransient<ICourseRepository, EFCourseRepository>();

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            });
            SeedData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
