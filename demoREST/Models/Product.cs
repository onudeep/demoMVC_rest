using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace demoREST.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ProductCatalogContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}