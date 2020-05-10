#pragma checksum "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2946f5e0d6a31b5f77bc9cf43861a27e3f4f1367"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorIntro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro;

#line default
#line hidden
#line 7 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/multipleparameter")]
    public partial class MultipleParameter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MultipleParameter</h3>\r\n\r\n");
            __builder.OpenElement(1, "input");
            __builder.AddAttribute(2, "id", "parameterwithseperatevalues");
            __builder.AddAttribute(3, "maxlength", 
#line 4 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor"
                                                    MaxLength

#line default
#line hidden
            );
            __builder.AddAttribute(4, "placeholder", 
#line 4 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor"
                                                                             Placeholder

#line default
#line hidden
            );
            __builder.AddAttribute(5, "required", 
#line 4 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor"
                                                                                                     Required

#line default
#line hidden
            );
            __builder.AddAttribute(6, "size", 
#line 4 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor"
                                                                                                                      Size

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "id", "parameterwithdictionary");
            __builder.AddMultipleAttributes(10, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 5 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor"
                                                 InputAttributes

#line default
#line hidden
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 7 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\MultipleParameter.razor"
       
    [Parameter]
    public string MaxLength { get; set; } = "10";
    [Parameter]
    public string Placeholder { get; set; } = "First Name";
    [Parameter]
    public string Required { get; set; } = "required";
    [Parameter]
    public string Size { get; set; } = "50";

    public Dictionary<string, object> InputAttributes { get; set; } = new Dictionary<string, object>
{
        {"maxlength","10" },
        {"placeholder","FirstName" },
        {"required","required" },
        {"size","50" }
    };

#line default
#line hidden
    }
}
#pragma warning restore 1591