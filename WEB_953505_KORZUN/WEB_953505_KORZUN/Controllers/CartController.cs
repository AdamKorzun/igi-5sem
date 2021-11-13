using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_953505_KORZUN.Data;
using WEB_953505_KORZUN.Extensions;
using WEB_953505_KORZUN.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_953505_KORZUN.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;
        private string cartKey = "cart";
        private Cart _cart;

        public CartController(ApplicationDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_cart.Items.Values  );
        }
        [Authorize]
        public IActionResult Add(int id, string returnUrl)
        {
            var item = _context.Products.Find(id);
            if (item != null)
            {
                _cart.AddToCart(item);
                HttpContext.Session.Set<Cart>(cartKey, _cart);
            }
            return Redirect(returnUrl);
        }
        public IActionResult Delete(int id)
        {
            _cart.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}
