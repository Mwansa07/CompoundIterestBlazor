#pragma checksum "/Users/mwansapembanyali/Projects/ClCalc/Pages/CompoundInterest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f78c027e58b5d6fbddb19c40d6b726ba6dbe66"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ClCalc.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using ClCalc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/mwansapembanyali/Projects/ClCalc/_Imports.razor"
using ClCalc.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/compoundinterest")]
    public partial class CompoundInterest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/Users/mwansapembanyali/Projects/ClCalc/Pages/CompoundInterest.razor"
 
    private double Principal { get; set; } = 5000;
    private double InterestRate { get; set; } = 5;
    private int Years { get; set; } = 10;
    private double total { get; set; } = 0;
    private string Total { get; set; }

    private void Calculate()
    {
        var total = Principal * Math.Pow(1 + InterestRate / (1200.0), Years * 12);
        Total = total.ToString("C");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
