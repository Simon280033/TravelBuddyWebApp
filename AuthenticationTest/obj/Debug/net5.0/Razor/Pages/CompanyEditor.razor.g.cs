#pragma checksum "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1872b6c2815a439d47f0289982eefbe094b701f3"
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
#line 2 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
using AuthenticationTest.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
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
            __builder.AddMarkupContent(0, "<h3>CompanyEditor</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-xl-6");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "companyNameField");
            __builder.AddMarkupContent(5, "<div><label>Sight name: </label></div>\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "placeholder", "Company name...");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
                                                          companyName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => companyName = __value, companyName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "addressField");
            __builder.AddMarkupContent(13, "<div><label>Address: </label></div>\r\n        ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "placeholder", "Company address...");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
                                                             companyAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => companyAddress = __value, companyAddress));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    \r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "emailField");
            __builder.AddMarkupContent(21, "<div><label>E-mail: </label></div>\r\n        ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "placeholder", "E-mail...");
            __builder.AddAttribute(24, "readonly");
            __builder.AddAttribute(25, "disabled", "true");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
                                                                             companyEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => companyEmail = __value, companyEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    \r\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "phoneField");
            __builder.AddMarkupContent(31, "<div><label>Phone: </label></div>\r\n        ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "placeholder", "Phone number...");
            __builder.AddAttribute(34, "type", "number");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
                                                                        companyPhone

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => companyPhone = __value, companyPhone, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    \r\n    ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(38);
            __builder.AddAttribute(39, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
                          args => SaveCompanyInfo()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(40, "Text", "Save Company info");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "style", "color:red");
            __builder.AddContent(44, 
#nullable restore
#line 45 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
                        ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\CompanyEditor.razor"
       
    private string companyName = "";
    private string companyAddress = "";
    private string companyEmail = "";
    private string companyPhone = "";

    private string ErrorMessage = "";

    protected override async Task OnInitializedAsync()
    {
        IfNotAuthorized();
        
        SetEmailFromUser();
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

    private async void SaveCompanyInfo()
    {
        if (AllFilled())
        {
            Console.WriteLine("All filled! Attempting to save in DB...");
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
            NavManager.NavigateTo("TourManager");
        }
        else
        {
            Console.WriteLine("Lacking info!");
            ErrorMessage = "Please fill out all of the required information!";
            StateHasChanged();
        }
        ErrorMessage = "";
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
