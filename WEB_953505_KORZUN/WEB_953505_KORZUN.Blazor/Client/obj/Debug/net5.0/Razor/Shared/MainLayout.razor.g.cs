#pragma checksum "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62f5a81aa2223e2bb2e02560087af9982574131f"
// <auto-generated/>
#pragma warning disable 1591
namespace WEB_953505_KORZUN.Blazor.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using WEB_953505_KORZUN.Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using WEB_953505_KORZUN.Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/_Imports.razor"
using WEB_953505_KORZUN.Blazor.Client.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ucpildrh75");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-ucpildrh75");
            __builder.OpenComponent<WEB_953505_KORZUN.Blazor.Client.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-ucpildrh75");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-ucpildrh75><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-ucpildrh75>About</a></div>\n\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-ucpildrh75");
            __builder.AddContent(15, 
#nullable restore
#line 14 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
