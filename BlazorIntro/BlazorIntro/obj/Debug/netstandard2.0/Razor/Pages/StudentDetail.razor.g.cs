#pragma checksum "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\StudentDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2574d7239554ed759a2a9be7ecb73ff5fc3a5f7e"
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
    public partial class StudentDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "StudentDetail for ");
            __builder.AddContent(2, 
#line 1 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\StudentDetail.razor"
                       StudentName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\StudentDetail.razor"
                                          Tikla

#line default
#line hidden
            ));
            __builder.AddContent(7, "Kaydet");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 5 "C:\Users\casper\Desktop\BlazorIntro\BlazorIntro\Pages\StudentDetail.razor"
       
    [Parameter]
    public string StudentName { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> Tikla { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
