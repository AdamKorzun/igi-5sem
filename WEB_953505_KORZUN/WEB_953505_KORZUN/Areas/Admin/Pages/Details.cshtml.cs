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
    public class DetailsModel : PageModel
    {
        private readonly WEB_953505_KORZUN.Data.ApplicationDbContext _context;

        public DetailsModel(WEB_953505_KORZUN.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products
                .Include(p => p.Group).FirstOrDefaultAsync(m => m.ProductId == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
