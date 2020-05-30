using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mikan.BL;
using Mikan.BL.Interfaces;
using Mikan.DAL;

namespace Mikan
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllersWithViews();
      // In production, the Angular files will be served from this directory
      services.AddSpaStaticFiles(configuration =>
      {
        configuration.RootPath = "ClientApp/dist";
      });

      services.AddDbContext<AgricultureContext>(
          options => options.UseSqlServer(
              Configuration.GetConnectionString("AgricultureConnection")));

      services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
      services.AddScoped(typeof(IActionService), typeof(ActionService));
      services.AddScoped(typeof(IResourceActionService), typeof(ResourceActionService));
      services.AddScoped(typeof(IResourceService), typeof(ResourceService));
      services.AddScoped(typeof(IMechanicalResourceService), typeof(MechanicalResourceService));
      services.AddScoped(typeof(IMechanicalResourceYearService), typeof(MechanicalResourceYearService));
      services.AddScoped(typeof(IResourceSubTypeService), typeof(ResourceSubtypeService));
      services.AddScoped(typeof(IMainResourceService), typeof(MainResourceService));
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
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();
      if (!env.IsDevelopment())
      {
        app.UseSpaStaticFiles();
      }

      app.UseRouting();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{controller}/{action=Index}/{id?}");
      });

      app.UseSpa(spa =>
            {
              // To learn more about options for serving an Angular SPA from ASP.NET Core,
              // see https://go.microsoft.com/fwlink/?linkid=864501

              spa.Options.SourcePath = "ClientApp";

              if (env.IsDevelopment())
              {
                spa.UseAngularCliServer(npmScript: "start");
              }
            });
    }
  }
}
