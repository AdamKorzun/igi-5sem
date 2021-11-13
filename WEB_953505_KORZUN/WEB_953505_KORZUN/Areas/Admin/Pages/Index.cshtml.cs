using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WEB_953505_KORZUN.Data;
using WEB_953505_KORZUN.Entities;

namespace WEB_953505_KORZUN.Areas.Admin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly WEB_953505_KORZUN.Data.ApplicationDbContext _context;

        public IndexModel(WEB_953505_KORZUN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.Group).ToListAsync();
        }
    }
}
