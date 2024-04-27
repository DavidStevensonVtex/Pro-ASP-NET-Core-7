﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContentController : ControllerBase
    {
        private DataContext context;

        public ContentController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet("string")]
        public string GetString() => "This is a string response";

        // Test: http://localhost:5000/api/content/object/xml
        // Test: http://localhost:5000/api/content/object/json
        [HttpGet("object/{format?}")]
        [FormatFilter]
        [Produces("application/json", "application/xml")]
        public async Task<ProductBindingTarget> GetObject()
        {
            Product p = await context.Products.FirstAsync();
            return new ProductBindingTarget() 
            { 
                Name = p.Name, 
                Price = p.Price, 
                CategoryId = p.CategoryId, 
                SupplierId = p.SupplierId 
            };
        }
    }
}
