#pragma checksum "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "532aa4859475fd47497291e9a2ea82d67ddcf057"
// <auto-generated/>
#pragma warning disable 1591
namespace WEB_953505_KORZUN.Blazor.Client.Components
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
    public partial class ProductsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Products list</h3>");
#nullable restore
#line 2 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
 if (Products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Загрузка ...</p>");
#nullable restore
#line 5 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "list-group");
#nullable restore
#line 9 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
      
        var i = 1;
        foreach (var product in Products)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "type", "button");
            __builder.AddAttribute(6, "class", "list-group-item" + " list-group-item-action" + "\n                    " + (
#nullable restore
#line 15 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
                      SelectedId == product.ProductId ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
                                e => Selected(e, product.ProductId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, 
#nullable restore
#line 17 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
              i++

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " - ");
            __builder.AddContent(10, 
#nullable restore
#line 17 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
                      product.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
        }
    

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Components/ProductsList.razor"
       
    [Parameter]
    public IEnumerable<ListViewModel> Products { get; set; }
    private int SelectedId = 0;
    [Parameter]
    public EventCallback<int> SelectedObjectChanged { get; set; }
    private void Selected(MouseEventArgs e, int id)
    {
        SelectedId = id;
        SelectedObjectChanged.InvokeAsync(id);
    }
    [Parameter]
    public EventCallback<IEnumerable<ListViewModel>> ProductsChanged
    {
        get; set;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
