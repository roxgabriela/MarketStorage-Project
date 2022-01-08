using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MarketStorage.Data;
using MarketStorage.Models;

namespace MarketStorage.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly MarketStorage.Data.MarketStorageContext _context;

        public IndexModel(MarketStorage.Data.MarketStorageContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.Include(b => b.Manufacturer).ToListAsync();
        }
    }
}
