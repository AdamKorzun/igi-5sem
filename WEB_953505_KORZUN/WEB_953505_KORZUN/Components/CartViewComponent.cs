using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_953505_KORZUN.Extensions;
using WEB_953505_KORZUN.Models;

namespace WEB_953505_KORZUN.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
