#pragma checksum "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Pages\Dashboard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f220f1b1b018e4b36b909fb8dd0973a78bd88bc"
// <auto-generated/>
#pragma warning disable 1591
namespace TrashBountyWebsite.Client.Pages
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
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyLib.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dashboard")]
    public partial class Dashboard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        Hello ");
                __builder2.AddContent(3, 
#nullable restore
#line 5 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Pages\Dashboard.razor"
               context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(4, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Pages\Dashboard.razor"
 
    async Task OnInitializedAsync()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
