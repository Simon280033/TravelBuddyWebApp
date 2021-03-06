// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AuthenticationTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using AuthenticationTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using AuthenticationTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\CompanyEditor.razor"
using AuthenticationTest.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\CompanyEditor.razor"
using AuthenticationTest.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CompanyEditor")]
    public partial class CompanyEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\CompanyEditor.razor"
       
    private bool CompanyTiedToUser = false;
    private string companyName = "";
    private string companyAddress = "";
    private string companyEmail = "";
    private string companyPhone = "";

    private string ErrorMessage = "";

    protected override async Task OnInitializedAsync()
    {
        IfNotAuthorized();
        
        SetEmailFromUser();
        
        // We check if company details are tied to user
        CompanyTiedToUser = _daoFetcher.CompanyDao().userTiedToCompany(auth.GetAuthenticationStateAsync().Result.User.Identity.Name);
        
        if (CompanyTiedToUser)
        {
            Company tempCompany = _daoFetcher.CompanyDao().getCompanyForUserById(auth.GetAuthenticationStateAsync().Result.User.Identity.Name);
            companyName = tempCompany.name;
            companyAddress = tempCompany.address;
            companyPhone = tempCompany.phone;
        }
    }
    
    private async void IfNotAuthorized()
    {
    // We check if the user is logged in
        bool isAuthenticated = auth.GetAuthenticationStateAsync().Result.User.Identity.IsAuthenticated;

        if (!isAuthenticated)
        {
    // If not authenticated, we redirect to main page
            await JsRuntime.InvokeVoidAsync("alert", "NOTICE: This page is only for registered users! Please sign in or register.");
            NavManager.NavigateTo("/");
        }
    }

    private void SetEmailFromUser()
    {
        companyEmail = auth.GetAuthenticationStateAsync().Result.User.Identity.Name;
    }

    private bool AllFilled()
    {
        bool allFilled = true;

        if (companyName.Length < 3)
        {
            return false;
        }

        if (companyAddress.Length < 5)
        {
            return false;
        }

        if (companyPhone.Length < 4) // Shortest possible phone number
        {
            return false;
        }

        return allFilled;
    }

    private async void CreateAndTieToUser()
    {
    // We attempt to save in DB
        Company company = new Company
        {
            id = 0,
            address = companyAddress,
            email = companyEmail,
            name = companyName,
            phone = companyPhone
        };

        try
        {
            _daoFetcher.CompanyDao().CreateCompany(company);
            _daoFetcher.CompanyDao().TieCompanyToUser(company);
        }
        catch (Exception)
        {
            ErrorMessage = "Failed to create company! Please try another name.";
        }
            
    // We save into singleton
        TheCompany.name = companyName;
        TheCompany.email = companyEmail;
        TheCompany.address = companyAddress;
        TheCompany.phone = companyPhone;
            
    // We redirect to main page
        await JsRuntime.InvokeVoidAsync("alert", "Company details successfully updated!");
        NavManager.NavigateTo("/");
    }

    private async void UpdateCompany()
    {
        Company company = new Company
        {
            id = TheCompany.id,
            address = companyAddress,
            email = companyEmail,
            name = companyName,
            phone = companyPhone
        };

        try
        {
            _daoFetcher.CompanyDao().UpdateCompany(company);
        }
        catch (Exception)
        {
            ErrorMessage = "Failed to update company!";
        }
            
    // We save into singleton
        TheCompany.name = companyName;
        TheCompany.address = companyAddress;
        TheCompany.phone = companyPhone;
            
    // We redirect to main page
        await JsRuntime.InvokeVoidAsync("alert", "Company details successfully updated!");
        NavManager.NavigateTo("/");
    }

    private async void SaveCompanyInfo()
    {
        if (AllFilled())
        {
            if (CompanyTiedToUser)
            {
                UpdateCompany();
            }
            else
            {
                CreateAndTieToUser();
            }
        }
        else
        {
            ErrorMessage = "Please fill out all of the required information!";
            StateHasChanged();
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDAOFetcher _daoFetcher { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Company TheCompany { get; set; }
    }
}
#pragma warning restore 1591
