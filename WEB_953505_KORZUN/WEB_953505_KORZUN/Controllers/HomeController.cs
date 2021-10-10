using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WEB_953505_KORZUN.Controllers
{
    public class HomeController : Controller
    {
        private List<ListDemo> listDemo;
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Text"] = "Лабораторная работа 2";
            ViewData["List"] = new SelectList(listDemo, "ListItemValue", "ListItemText");
            return View();
        }
        public HomeController()
        {
            listDemo = new List<ListDemo>
            {
                new ListDemo{ListItemText = "Item 1", ListItemValue = 1},
                new ListDemo{ListItemText = "Item 2", ListItemValue = 2},
                new ListDemo{ListItemText = "Item 3", ListItemValue = 3}

            };
        }
    }
    public  class ListDemo
    {
        public int ListItemValue { get; set; }
        public string ListItemText { get; set; }
    }
}
