using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MarketStorage.Models;

namespace MarketStorage.Data
{
    public class MarketStorageContext : DbContext
    {
        public MarketStorageContext (DbContextOptions<MarketStorageContext> options)
            : base(options)
        {
        }

        public DbSet<MarketStorage.Models.Product> Product { get; set; }

        public DbSet<MarketStorage.Models.Manufacturer> Manufacturer { get; set; }

        public DbSet<MarketStorage.Models.Category> Category { get; set; }
    }
}
