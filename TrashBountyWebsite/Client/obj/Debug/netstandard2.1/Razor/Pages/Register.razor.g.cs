#pragma checksum "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847bbc1971273013889d4c7dc6e42ac3c239d5a8"
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
#line 1 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyWebsite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyWebsite.Client.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyWebsite.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyLib;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\_Imports.razor"
using TrashBountyLib.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .main {\r\n        width: 100vw;\r\n        min-height: calc(100vh - 64px); /* Full page height minus nav bar */\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n        flex-direction: column;\r\n    }\r\n\r\n    .form-input {\r\n        margin-bottom: 32px;\r\n        position: relative;\r\n    }\r\n\r\n    .form-input input {\r\n        display: block;\r\n        border: none;\r\n        font-size: 24px;\r\n        border-bottom: 2px solid #238531;\r\n        font-family: \'Public Sans\', sans-serif;\r\n        box-shadow: none !important;\r\n        transition: 0.3s;\r\n    }\r\n\r\n    .form-input input.invalid {\r\n        border-bottom: 2px solid #ff4d4d;\r\n    }\r\n\r\n    input[type=\"submit\"] {\r\n        border: 4px solid #238531;\r\n        border-radius: 64px;\r\n        background-color: #fff;\r\n        color: #238531;\r\n        font-size: 1rem;\r\n        padding: 16px;\r\n        margin-top: 16px;\r\n        transition: 0.3s;\r\n        box-shadow: 0 1px 3px rgba(0, 0, 0, .25);\r\n        cursor: pointer;\r\n    }\r\n\r\n    input[type=\"submit\"]:hover {\r\n        background-color: #238531;\r\n        color: #fff;\r\n        box-shadow: 0 10px 30px rgba(0, 0, 0, .25);\r\n    }\r\n\r\n    .form-input label {\r\n        display: block;\r\n        font-family: \'Public Sans\', sans-serif;\r\n        color: #ccc;\r\n    }\r\n\r\n    .form-input .validation-message {\r\n        font-family: \'Public Sans\', sans-serif;\r\n        color: #ff4d4d;\r\n        position: absolute;\r\n        bottom: -20px; /* 16 for the font height and 4 for padding */\r\n        white-space: nowrap;\r\n        animation: fadein 0.3s ease forwards;\r\n    }\r\n\r\n    ::placeholder {\r\n        color: #ccc;\r\n    }\r\n\r\n    @keyframes fadein {\r\n        0% {opacity: 0;}\r\n        100% {opacity: 1;}\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h1>Sign up</h1>\r\n");
            __builder.AddMarkupContent(2, "<p>Already have an account? <a href=\"/login\">Log in</a></p>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "model", 
#nullable restore
#line 80 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                  user

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 80 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                        RegisterUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-input");
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.AddMarkupContent(13, "<label for=\"email\">Email</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "email");
                __builder2.AddAttribute(16, "type", "email");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 84 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                                        user.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __Blazor.TrashBountyWebsite.Client.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 85 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                  () => user.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(23, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-input");
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.AddMarkupContent(28, "<label for=\"username\">Username</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "id", "username");
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 89 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                                          user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Username = __value, user.Username))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __Blazor.TrashBountyWebsite.Client.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 90 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                  () => user.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(38, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-input");
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.AddMarkupContent(43, "<label for=\"pwd1\">Enter a password</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "pwd1");
                __builder2.AddAttribute(46, "type", "password");
                __builder2.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 94 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                                          user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(49, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n        ");
                __Blazor.TrashBountyWebsite.Client.Pages.Register.TypeInference.CreateValidationMessage_2(__builder2, 51, 52, 
#nullable restore
#line 95 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                  () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-input");
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.AddMarkupContent(58, "<label for=\"pwd2\">Confirm your password</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "id", "pwd2");
                __builder2.AddAttribute(61, "type", "password");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 99 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                                          user.PasswordConfirm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.PasswordConfirm = __value, user.PasswordConfirm))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.PasswordConfirm));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __Blazor.TrashBountyWebsite.Client.Pages.Register.TypeInference.CreateValidationMessage_3(__builder2, 66, 67, 
#nullable restore
#line 100 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
                                  () => user.PasswordConfirm

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    <input type=\"submit\" value=\"Register\">\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\Kaushik\source\repos\TrashBountyAPI\TrashBountyWebsite\Client\Pages\Register.razor"
 
    private NewUser user = new NewUser();

    protected override async Task OnInitializedAsync()
    {

    }

    private async Task RegisterUser()
    {
        var response = await Http.PostAsJsonAsync("https://localhost:44399/api/users", user);

        var jsonString = await response.Content.ReadAsStringAsync();
        TrashBountyLib.Models.Results.RegisterResult result = JsonConvert.DeserializeObject<TrashBountyLib.Models.Results.RegisterResult>(jsonString);

        if (result.Successful)
        {
            Console.WriteLine("User Registered");
            NavigationManager.NavigateTo("/login");
        }

        else
        {
            foreach (var error in result.Errors)
            {
                Console.WriteLine(error);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.TrashBountyWebsite.Client.Pages.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
