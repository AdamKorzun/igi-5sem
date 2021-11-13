using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WEB_953505_KORZUN.Data;
using WEB_953505_KORZUN.Entities;
using WEB_953505_KORZUN.Extensions;
using WEB_953505_KORZUN.Models;

namespace WEB_953505_KORZUN.Controllers
{
    public class ProductController : Controller
    {
        int _pageSize;

        ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;

        }
        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo=1)
        {
            ViewData["Groups"] = _context.ProductGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            var productsFiltered = _context.Products
                .Where(d => !group.HasValue || d.ProductGroupId == group.Value);
            var model = ListViewModel<Product>.GetModel(productsFiltered, pageNo,_pageSize);
            if (Request.IsAjaxRequest())
            {
                return PartialView("_listpartial", model);
            }
            else return View(model);
        
        }
    }
 
}
