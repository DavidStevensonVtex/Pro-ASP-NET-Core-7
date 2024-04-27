using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using WebApp.Models;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.AspNetCore.Mvc;

namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<DataContext>(opts =>
            {
                opts.UseSqlServer(builder.Configuration["ConnectionStrings:ProductConnection"]);
                opts.EnableSensitiveDataLogging(true);
            });

            builder.Services.AddControllers().AddNewtonsoftJson();

            builder.Services.AddRateLimiter(opts =>
                opts.AddFixedWindowLimiter("fixedWindow", fixOpts =>
                {
                    fixOpts.PermitLimit = 1;
                    fixOpts.QueueLimit = 0;
                    fixOpts.Window = TimeSpan.FromSeconds(15);
                }));

            //builder.Services.Configure<JsonOptions>(opts =>
            //    opts.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull);

            builder.Services.Configure<MvcNewtonsoftJsonOptions>(opts =>
            {
                opts.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            });

            // https://learn.microsoft.com/en-gb/aspnet/core/security/cors?view=aspnetcore-7.0
            // The optoins pattern is used to configure CORS with the CorsOptions class defined
            // in the Microsoft.AspNetCore.Cors.Infrastructure namespace.
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                    policy =>
                    {
                        policy.WithOrigins("http://example.com",
                                            "http://www.contoso.com");
                    });
            });

            var app = builder.Build();

            app.UseRateLimiter();

            app.MapControllers();

            app.UseCors(MyAllowSpecificOrigins);

            var context = app.Services.CreateScope().ServiceProvider.GetRequiredService<DataContext>();
            SeedData.SeedDatabase(context);

            app.Run();
        }
    }
}
