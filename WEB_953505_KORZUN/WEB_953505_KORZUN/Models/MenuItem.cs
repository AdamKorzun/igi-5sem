using System;
namespace WEB_953505_KORZUN.Models
{
    public class MenuItem
    {
        public bool IsRazor { get; set; }
        public string Active { get; set; }
        public string ControllerName { get; set; }
        public string FuncName { get; set; }
        public string PageName { get; set; }
        public string AreaName { get; set; }
        public string Text { get; set; }
    }
}
