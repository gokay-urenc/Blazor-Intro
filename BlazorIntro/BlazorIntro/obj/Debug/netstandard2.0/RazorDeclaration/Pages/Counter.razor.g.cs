#pragma checksum "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9f88ba7d67ddae52a0dbb882fdba237b26ae6b8"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorIntro.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro;

#line default
#line hidden
#line 7 "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\_Imports.razor"
using BlazorIntro.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 10 "D:\Applications\C#\Web Applications\Blazor\Blazor_1_Intro\BlazorIntro\BlazorIntro\Pages\Counter.razor"
       
    int currentCount = 0;

    void IncrementCount()
    {
        currentCount++;
    }

    void IncrementCount2()
    {
        currentCount+=2;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
