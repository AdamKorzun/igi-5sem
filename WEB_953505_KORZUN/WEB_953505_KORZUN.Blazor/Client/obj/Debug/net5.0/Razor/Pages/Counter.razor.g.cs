#pragma checksum "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cee86e31ad9577bec0efea7e42383fd67838f5f"
// <auto-generated/>
#pragma warning disable 1591
namespace WEB_953505_KORZUN.Blazor.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Pages/Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Pages/Counter.razor"
                 formModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Pages/Counter.razor"
                                           SetCounter

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n    ");
                __Blazor.WEB_953505_KORZUN.Blazor.Client.Pages.Counter.TypeInference.CreateInputNumber_0(__builder2, 13, 14, 
#nullable restore
#line 9 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Pages/Counter.razor"
                              formModel.NewValue

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formModel.NewValue = __value, formModel.NewValue)), 16, () => formModel.NewValue);
                __builder2.AddMarkupContent(17, "\n    <input type=\"submit\" class=\"btn btn-outline-info mt-2 mb-2\" value=\"Set counter\">");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\n");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Pages/Counter.razor"
       
    private FormModel formModel;
    private int currentCount = 0;
    protected override void OnInitialized()
    {
        formModel = new();
    }
    private void IncrementCount()
    {
        currentCount++;
    }
    class FormModel
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/Users/adam/Desktop/igi-5sem/WEB_953505_KORZUN/WEB_953505_KORZUN.Blazor/Client/Pages/Counter.razor"
                                  
        public int NewValue { get; set; }
    }
    private void SetCounter()
    {
        currentCount = formModel.NewValue;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.WEB_953505_KORZUN.Blazor.Client.Pages.Counter
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
