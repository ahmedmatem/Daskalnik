using Web.Areas.Extensions;

namespace Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddApplicationDbContext(builder.Configuration);

            builder.Services.AddApplicationIdentity();

            builder.Services.AddControllersWithViews();

            builder.Services.AddApplicationServices();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapAreaControllerRoute(
                name: "Admin",
                areaName: "Admin",
                pattern: "admin/{controller=Home}/{action=Index}/{id?}");
            app.MapDefaultControllerRoute();
            
            app.MapRazorPages();

            app.Run();
        }
    }
}