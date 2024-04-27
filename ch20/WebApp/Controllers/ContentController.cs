using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    public class ContentController : ControllerBase
    {
        private DataContext context;

        public ContentController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet("string")]
        public string GetString() => "This is a string response";

        [HttpGet("object")]
        public async Task<Product> GetObject()
        {
            return await context.Products.FirstAsync();
        }
    }
}
