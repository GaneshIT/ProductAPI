using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DAL.Data
{
    public class ProductDbContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public ProductDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection"));
        }
        public DbSet<Colour> colours { get; set; }
        public DbSet<SizeScale> SizeScales { get; set; }
        public DbSet<ProductEntity.Models.Product> Products { get; set; }
        public DbSet<Article> articles { get; set; }
    }
}
