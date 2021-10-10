using System;
using Microsoft.AspNetCore.Mvc;

namespace WEB_953505_KORZUN.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
