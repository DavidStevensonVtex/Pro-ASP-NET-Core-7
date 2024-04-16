using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

namespace SportsStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var connection = builder.Configuration["ConnectionStrings:SportsStoreConnection"];

            builder.Services.AddDbContext<StoreDbContext>(opts =>
                opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportsStoreConnection"]));

            var app = builder.Build();

            app.UseStaticFiles();
            app.MapDefaultControllerRoute();

            app.Run();
        }
    }
}
