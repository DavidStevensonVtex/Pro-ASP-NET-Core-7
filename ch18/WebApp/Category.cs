﻿namespace WebApp
{
    public class Category
    {
        public long CategoryId { get; set; }
        public required string Name { get; set; }

        public IEnumerable<Product>? { get ; set; }
    }
}
