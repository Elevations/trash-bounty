#pragma checksum "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4605cadd3e2ea6540d82babec95c2fda8325dee3"
// <auto-generated/>
#pragma warning disable 1591
namespace TrashBountyWebsite.Client.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyWebsite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyWebsite.Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyWebsite.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using AspNetMonsters.Blazor.Geolocation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyLib.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenComponent<TrashBountyWebsite.Client.Shared.Nav>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "main");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddContent(8, 
#nullable restore
#line 8 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
