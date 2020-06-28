#pragma checksum "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Shared\Nav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fde8ff353c65c921cbe9c8913e12e6dafcce501"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 1 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Shared\Nav.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    public partial class Nav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Shared\Nav.razor"
 
    private string sideNavStatus = "closed";

    private void ToggleNav(MouseEventArgs e)
    {
        if (sideNavStatus.Equals("closed"))
        {
            sideNavStatus = "opened";
        }
        else
        {
            sideNavStatus = "closed";
        }
    }

    private void Logout()
    {
        AuthService.Logout();
        NavigationManager.NavigateTo("/login");
    }

    private void ToggleNavAndLogout(MouseEventArgs e)
    {
        ToggleNav(e);
        Logout();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthService AuthService { get; set; }
    }
}
#pragma warning restore 1591
