#pragma checksum "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b19355102722678e0e5b9e17a2d3af44972b7a48"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthenticationTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using AuthenticationTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using AuthenticationTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
using Npgsql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
using AuthenticationTest.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
using AuthenticationTest.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
using AuthenticationTest.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<AuthenticationTest.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Index.razor"
 
    protected override async Task OnInitializedAsync()
    {
        ifAuthenticated();
    }

    private async void ifAuthenticated()
    {
        // We check if the user is logged in
        bool isAuthenticated = auth.GetAuthenticationStateAsync().Result.User.Identity.IsAuthenticated;

        if (isAuthenticated)
        {
            // We check if company details are tied to user
            bool isTied = _daoFetcher.CompanyDao().userTiedToCompany(auth.GetAuthenticationStateAsync().Result.User.Identity.Name);

            if (isTied)
            {
                TheCompany.id = _daoFetcher.CompanyDao().getCompanyForUserById(auth.GetAuthenticationStateAsync().Result.User.Identity.Name).id;
            }
            else
            {
                await JsRuntime.InvokeVoidAsync("alert", "WELCOME! As this is the first time you are using this tool, please fill out company information.");
                NavManager.NavigateTo("CompanyEditor");
            }
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Company TheCompany { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDAOFetcher _daoFetcher { get; set; }
    }
}
#pragma warning restore 1591
