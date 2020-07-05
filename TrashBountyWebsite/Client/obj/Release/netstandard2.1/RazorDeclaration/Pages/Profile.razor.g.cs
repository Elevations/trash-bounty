#pragma checksum "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb901d0c00cbef3de849151a425d4cc1e093ea2c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile/{Id}")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Mihir\Source\Repos\TrashBounty\TrashBountyWebsite\Client\Pages\Profile.razor"
 
    [Parameter]
    public string Id { get; set; }

    private string username = "";
    private string profileImgLink = "";

    private APIUser user = new APIUser();

    protected override async Task OnInitializedAsync()
    {
        user = await Http.GetFromJsonAsync<APIUser>($"https://localhost:44399/api/users/{Id}");
        username = user.Username;
        profileImgLink = user.ProfileImageLink;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
