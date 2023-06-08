using Microsoft.OpenApi.Models;
using System.Reflection;
using GiniApps.Task.Logic.Extentions;
using Microsoft.AspNetCore.Http;
using GiniApps.Task.Middlewares;

namespace GiniApps.Task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var version = $"v{Assembly.GetExecutingAssembly().GetName().Version}";

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddSwaggerGen(c => c.SwaggerDoc(version, new OpenApiInfo { Title = "GiniApps task API", Version = version }));
            builder.Services.AddSession(options =>
            {
                options.Cookie.IsEssential = true;
                options.Cookie.HttpOnly = true;
                options.IdleTimeout = TimeSpan.FromDays(5);
            });

            // Add app logic services
            builder.Services.AddLogicServices();
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                builder.Services.AddCors();
                app.UseCors(x =>
                    x
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) // allow any origin
                    .AllowCredentials() // allow credentials
                );
            }
            app.UseSession().UseMiddleware<BookmarkMiddleware>();

            app.UseStaticFiles();
            app.UseRouting();

            app.UseSwagger(c =>
            {
                c.SerializeAsV2 = true;
            });

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"GiniApps task API {version}");
                c.RoutePrefix = "swagger";
            });


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");

            app.Run();
        }
    }
}