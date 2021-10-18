using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WEB_953505_KORZUN.Models;

namespace WEB_953505_KORZUN.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private List<MenuItem> menuItems = new List<MenuItem>
        {
            new MenuItem{ControllerName="Home", FuncName="Index", Text="Lab 2"},
            new MenuItem{ControllerName="Product", FuncName="Index", Text="Каталог"},
            new MenuItem{IsRazor=true , AreaName="Admin", PageName="/Index", Text="Администрирование"}

        };
        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];
            foreach (var item in menuItems)
            {
                bool controllerMatch = controller?.Equals(item.ControllerName) ?? false;
                bool areaMatch = area?.Equals(item.AreaName) ?? false;
                if (controllerMatch || areaMatch)
                {
                    item.Active = "active";
                }

            }
            return View(menuItems);

        }
    }
}
