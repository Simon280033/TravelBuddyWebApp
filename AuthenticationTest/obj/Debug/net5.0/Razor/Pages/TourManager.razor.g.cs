#pragma checksum "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb5eed805ae98f8f3046099227ad81370ff44a4"
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
#line 2 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
using AuthenticationTest.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
using ImageConverter = AuthenticationTest.Data.Converters.Concrete.ImageConverter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
using AuthenticationTest.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TourManager/{PathParam}")]
    public partial class TourManager : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "h2");
            __builder.AddContent(3, 
#nullable restore
#line 12 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
     HeaderText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.AddMarkupContent(5, "<div class=\"container\"><div><label>Tour image: </label></div></div>\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "width", "300");
            __builder.AddAttribute(10, "height", "300");
            __builder.AddAttribute(11, "src", "data:image/*;base64," + (
#nullable restore
#line 20 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                            TheTour.ImageBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.AddMarkupContent(13, "<div class=\"container\"><div><label>Upload image: </label></div></div>\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(16);
            __builder.AddAttribute(17, "id", "image-picker");
            __builder.AddAttribute(18, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                            UploadImage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(19, "accept", "image/*");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "container");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "color:red");
            __builder.AddContent(25, 
#nullable restore
#line 32 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                            MissingInfoErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "container");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "style", "color:red");
            __builder.AddContent(31, 
#nullable restore
#line 35 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                            VariantAddingMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "container");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                      ToggleLanguageChoiceVisibility

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "class", "button-green");
            __builder.AddAttribute(38, "style", "margin: 15px;");
            __builder.AddAttribute(39, "disabled", 
#nullable restore
#line 39 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                                                            disableAddingNewVariants

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(40, "<i style=\"vertical-align: middle; margin-right: 5px;\" class=\"material-icons\">language</i>Add new language variant");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n<div class=\"container\"></div>\r\n\r\n");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "container");
            __builder.AddAttribute(44, "hidden", 
#nullable restore
#line 45 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                hideLanguageChoice

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "<b><label for=\"languageCodes\">Language:</label></b>");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "container");
            __builder.AddAttribute(49, "hidden", 
#nullable restore
#line 49 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                hideLanguageChoice

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(50, "select");
            __builder.AddAttribute(51, "id", "languageCodes");
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                          TourLanguageChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "name", "languageCodes");
#nullable restore
#line 51 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
         foreach (Language language in AvailableLanguages)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "option");
            __builder.AddContent(55, 
#nullable restore
#line 53 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                     language.LanguageName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "container");
            __builder.AddAttribute(59, "hidden", 
#nullable restore
#line 58 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                hideLanguageChoice

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "type", "button");
            __builder.AddAttribute(62, "style", "margin: 10px;");
            __builder.AddAttribute(63, "class", "button-green");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                               () => AddRow()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "<i style=\"vertical-align: middle; margin-right: 5px;\" class=\"material-icons\">add_circle</i>Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "hidden", 
#nullable restore
#line 63 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
              hideVariantOverview

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 64 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
     for (int i = 0; i < TheTour.Variants.Count; i++)
    {
        int index = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "style", "text-align:center; background-color: #e8e8e8; padding: 15px; border-radius: 10px; margin: 10px;");
            __builder.AddMarkupContent(71, "<div style=\"margin:auto;\"><b>Language:</b></div>\r\n            ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "style", "margin:auto;");
            __builder.OpenElement(74, "i");
            __builder.AddContent(75, 
#nullable restore
#line 69 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                          TheTour.Variants[index].Language.LanguageName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n            ");
            __builder.AddMarkupContent(77, "<div style=\"margin:auto;\"><b>Name:</b></div>\r\n            ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "style", "margin:auto;");
            __builder.AddAttribute(80, "id", "nameInput@index");
            __builder.AddAttribute(81, "placeholder", "Tour" + " name" + " in" + " " + (
#nullable restore
#line 71 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                                        TheTour.Variants[index].Language.LanguageName

#line default
#line hidden
#nullable disable
            ) + "...");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                                                                                                        TheTour.Variants[index].TourName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TheTour.Variants[index].TourName = __value, TheTour.Variants[index].TourName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.AddMarkupContent(85, "<div style=\"margin:auto;\"><b>Description:</b></div>\r\n            ");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "style", "margin:auto;");
            __builder.AddAttribute(88, "id", "descInput@index");
            __builder.AddAttribute(89, "placeholder", "Tour" + " description" + " in" + " " + (
#nullable restore
#line 73 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                                               TheTour.Variants[index].Language.LanguageName

#line default
#line hidden
#nullable disable
            ) + "...");
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 73 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                                                                                                               TheTour.Variants[index].TourDescription

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TheTour.Variants[index].TourDescription = __value, TheTour.Variants[index].TourDescription));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "style", "margin:auto;");
            __builder.OpenElement(95, "button");
            __builder.AddAttribute(96, "type", "button");
            __builder.AddAttribute(97, "style", "margin-top: 10px;");
            __builder.AddAttribute(98, "class", "button-green");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                                               () => RemoveVariant(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(100, "Remove variant");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "container");
            __builder.OpenElement(104, "button");
            __builder.AddAttribute(105, "type", "button");
            __builder.AddAttribute(106, "class", "button-green");
            __builder.AddAttribute(107, "disabled", 
#nullable restore
#line 81 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                      DisableCreatingOrUpdatingTour

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(108, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                                               () => CreateOrUpdateTour()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(109, "<i style=\"vertical-align: middle; margin-right: 5px;\" class=\"material-icons\">cloud_upload</i>");
            __builder.AddContent(110, 
#nullable restore
#line 81 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
                                                                                                                                                                                                                         CreateOrUpdateButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\TourManager.razor"
       
    // Converters
    private IImageConverter imageConverter = new ImageConverter();
    
    // Bools for showing/hiding
    private bool Creating = true;
    private bool hideLanguageChoice = true;
    private bool hideVariantOverview = false;
    private bool disableAddingNewVariants = false;
    private bool DisableCreatingOrUpdatingTour = true;

    private string VariantAddingMessage = "";
    private string MissingInfoErrorMessage = "";
    private string HeaderText;
    private string CreateOrUpdateButtonText;
    private string selectedTourLanguageCode;
    
    // The tour we are working with
    private Tour TheTour = new Tour();
    
    private List<Language> Languages = new List<Language>();
    private List<Language> AddedLanguages = new List<Language>();
    private List<string> AddedCodes = new List<string>();
    private List<Language> AvailableLanguages = new List<Language>();
    private List<string> AvailableCodes = new List<string>();

    [Parameter]
    public string PathParam { get; set; }

    protected override async Task OnInitializedAsync()
    {
        IfNotAuthorized();
        
        Languages = _daoFetcher.LanguageDao().GetLanguages();

    // We set the layout depending on whether we are creating a new Tour or editing one
        Creating = Int32.Parse(PathParam) == 0;

        if (Creating)
        {
            SetLayoutForCreating();
        }
        else
        {
            setLayoutForEditing();
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

    private void SetLayoutForCreating()
    {
        selectedTourLanguageCode = Languages[0].LanguageCode;

        foreach (Language lang in Languages)
        {
            AvailableLanguages.Add(lang);
            AvailableCodes.Add(lang.LanguageCode);
        }
        
        TheTour = new Tour
        {
            Variants = new List<TourVariant>(),
            Id = TheTour.Variants.Count,
            ImageBase64 = "iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAJ1BMVEXt7e3V1dXW1tbm5ubs7Ozg4ODc3NzS0tLw8PDo6OjZ2dnj4+Pe3t5T9WAhAAAEmklEQVR4nO2ciXKsIBBFsQUB9f+/9+EuKjPEpe2X3FOVSTJlAmdaWRpUKQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP8Pbnh9mr4Uza+nnSpbChTTy0M/hNfKeNeXyIshW/BReaVZ4+h8zSY3lESG008rz+a30LIqFpbYDa1huxC1qovQDHAbUuG5DF3Tl8cmORdTs/Ua9VxuzUHXaA+WnsnQD90EUa1ZPlRtChoMuRobs5w0PLiGphJ5YlgNxVnGHrgeTlOuIkdD4imtx/B+qKNhzThOLF8xJE5D+4ohT2k9MLwZGD4ADG8Ghg8Aw5uB4QPINRxqdH14J9awmyG7summ5tfqJthQO1NY21wtUrKh7zJW9mqWTLLhcPDV9INYQ6XHqhXGXaqcXEM1L2/4S2k5qYbaNfP61LXEnFRDpWhJize/MIbrEAau1E6qoV75FfZKwlqmoVYmWiWmUp1ex5VpqKIQdhdkOG9/l2EcwuDYnu4UZRrq7frihSVOgYahKm2xUzw9eBNoqJy3O8Pi9CRDoqGqhv0+UQzpbKco0bAs9iEMVOeKlGeoVWpH0bnBmzxD5VMbbuhUJQUapkJI9tR5Ks+w+bBnqnRxXqr7razMx30d8gzTu4nI1nE1O8HWfkl0SDN0TXq7lKUwyYgqqrvDw9uftq1JM9RftoP57eF09PYaYYbOpNRG6vUIXLtqrH6bPk+FGX4LYdcpLripVSJbupSjMMNvISyiwZsu5sFdOlsly1Afa8Xn6Xzw9N96geTAXJShazMMi3I4WOsmejtlIMowbws4jRmbOOA2tV1dkGFoGbMMu9O0q24VZzpSSziCDKfttV8iSGOSv9wODRKjVkGGrs7Z/G0b1w/XdDy6Cz/b8rBIQYal3U7sj6j70WhoR+12AEt02CVKMdTpWVNk0TeZ4as5SgM0R8NTIYZDnTMYL7bjjpOO8uJCDFVeCKebX1Kt7tEcQ4xhXgjH/dPJgw96DCmGuyz3MdQ1pc4nj632QRRi+HXWNNJNghvz4cPwO0Uhht9nTeMfhqp+PGCf0BBimBnC8a8/fRzNdpFKhmFuCDOoZcYwa9aUyXZFXIThrTfO0qbHeN1QL+/exKbHeN1QZc6a8tnMMV431GHWdPM9s3W07/Z1Q+XKgxXfS8RZqfcN84bcP4LW6zfvG2YOuX9EGwavk9HrhvqBEEYbNt82/LTWdIFVVuptwweuwp6l23/bUD/zHJfVbsa3Df3nmcJpltP0bcPwziNR9GJaGqUbU91LG1g9BeN9w2v3GiSR0x8+9AAQSWOap4Hhzfx6Q1eNzxdiKU1F6yFshn0ILdPjcPoUCU2GLGVOeVG2p4u5aZWK68Lw/Vkavswdt/jmFDiN7A9WNB5hSf3WhoPpFKXrd9tmCi63irA8sI3mb+f2F58xvDF/n6VIwytXCFW/2Y7zyZ6TJVv3pPpnxPGzW655Ere9a+tpqLAVp2D/BNOa1TG54+1JfMXW4JDhDeCM9r5kwL+k92d4/vNFBAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD4Y/wDpoY2HBKwqLIAAAAASUVORK5CYII=",
            CompanyId = 0,
            Sights = null
        };
        
        CreateOrUpdateButtonText = "Create Tour with language variants";
        HeaderText = "Create new tour";
    }

    private void setLayoutForEditing()
    {
        TheTour = _daoFetcher.TourDao().getTourById(Int32.Parse(PathParam));
        
        // We set the ones added
        for (int i = 0; i < TheTour.Variants.Count; i++)
        {
            AddedLanguages.Add(TheTour.Variants[i].Language);
            AddedCodes.Add(TheTour.Variants[i].Language.LanguageCode);
        }
        // We set the removed ones
                for (int i = 0; i < Languages.Count; i++)
                {
                    if (!AddedCodes.Contains(Languages[i].LanguageCode))
                    {
                        AvailableLanguages.Add(Languages[i]);
                        AvailableCodes.Add(Languages[i].LanguageCode);
                    }
                }

        // We set the default language
        selectedTourLanguageCode = AvailableCodes[0];
        
        CreateOrUpdateButtonText = "Update Tour and language variants";
        HeaderText = "Update tour '" + TheTour.Variants[0].TourName + "'";

        DisableCreatingOrUpdatingTour = false;
        if (AvailableLanguages.Count == 0)
        {
            disableAddingNewVariants = true;
        } 
    }

    private Language GetLanguageByCode(string code)
    {
        for (int i = 0; i < Languages.Count; i++)
        {
            if (Languages[i].LanguageCode.Equals(code))
            {
                return Languages[i];
            }
        }

        return new Language
        {
            LanguageCode = "??",
            LanguageName = "Unknown language"
        };
    }

    private void AddRow()
    {
        TheTour.Variants.Add(new TourVariant
        {
            TourName = "",
            Language = GetLanguageByCode(selectedTourLanguageCode),
            TourDescription = ""
        });
        AddedLanguages.Add(GetLanguageByCode(selectedTourLanguageCode));
        AddedCodes.Add(GetLanguageByCode(selectedTourLanguageCode).LanguageCode);
        AvailableLanguages.Remove(GetLanguageByCode(selectedTourLanguageCode));
        AvailableCodes.Remove(GetLanguageByCode(selectedTourLanguageCode).LanguageCode);
        
        // We remove the available languages from the list
        // If it is the last language, we disable
        if (AvailableLanguages.Count == 0)
        {
            disableAddingNewVariants = true;
            VariantAddingMessage = "No more languages available to add variants for!";
        }
        else
        {
            selectedTourLanguageCode = AvailableCodes[0];
        }
        
        hideLanguageChoice = true;
        hideVariantOverview = false;
        DisableCreatingOrUpdatingTour = false;
    }

    private void ToggleLanguageChoiceVisibility()
    {
        hideLanguageChoice = !hideLanguageChoice;
    }
    
    private void ToggleVariantOverviewVisibility()
    {
        hideVariantOverview = !hideVariantOverview;
    }

    private void TourLanguageChanged(ChangeEventArgs e)
    {

        string languageName = (string) e.Value;
        foreach (Language language in Languages)
        {
            if (language.LanguageName.Equals(languageName))
            {
                // We set it as the selected
                selectedTourLanguageCode = language.LanguageCode;
                break;
            }
        }
    }

    private void CreateOrUpdateTour()
    {
        if (!AllFilled())
        {
            MissingInfoErrorMessage = "Please fill out ALL the required information for ALL of the language variants!";
            return;
        }
        else
        {
            MissingInfoErrorMessage = "";
        }
        
        if (Creating)
        {
            CreateTour();
        }
        else
        {
            UpdateTour();
        }
    }

    private async void CreateTour()
    {
        // We set the company id for the tour
        TheTour.CompanyId = _daoFetcher.CompanyDao().getCompanyForUserById(auth.GetAuthenticationStateAsync().Result.User.Identity.Name).id;
        _daoFetcher.TourDao().createTour(TheTour);
        await JsRuntime.InvokeVoidAsync("alert", "Tour '" + TheTour.Variants[0].TourName + "' succesfully created! Navigating to Sight Manager...");
        NavManager.NavigateTo("SightManager");
    }

    private async void UpdateTour()
    {
        Tour oldTour = _daoFetcher.TourDao().getTourById(TheTour.Id);
        // We check if any variants were deleted
        if (oldTour.Variants.Count > TheTour.Variants.Count)
        {
            // We make a list of new ids
            List<string> oldLanguages = new List<string>();
            foreach (TourVariant variant in oldTour.Variants)
            {
                oldLanguages.Add(variant.Language.LanguageCode);
            }
            List<string> newLanguages = new List<string>();
            foreach (TourVariant variant in TheTour.Variants)
            {
                newLanguages.Add(variant.Language.LanguageCode);
            }
            // We remove the ones
            for (int i = oldTour.Variants.Count - 1; i >= 0; i--)
            {
                if (!newLanguages.Contains(oldTour.Variants[i].Language.LanguageCode))
                {
                    oldTour.Variants.Remove(oldTour.Variants[i]);
                }
            }
        }
        // We check if any were added
        else if (oldTour.Variants.Count < TheTour.Variants.Count)
        {
    // We make a list of old ids
            List<string> ids = new List<string>();
            foreach (TourVariant variant in oldTour.Variants)
            {
                ids.Add(variant.Language.LanguageCode);
            }
    // We add the ones
            foreach (TourVariant variant in TheTour.Variants)
            {
                if (!ids.Contains(variant.Language.LanguageCode))
                {
                    oldTour.Variants.Add(variant);
                }
            }
        }
        // We check if any of them were changed
        foreach (TourVariant variant in oldTour.Variants)
        {
            // We get the new info
            foreach (TourVariant variant2 in TheTour.Variants)
            {
                if (variant.Language.LanguageCode.Equals(variant2.Language.LanguageCode))
                {
                    variant.TourName = variant2.TourName;
                    variant.TourDescription = variant2.TourDescription;
                }
            }
        }
        // We set the new image
        oldTour.ImageBase64 = TheTour.ImageBase64;
        // Then we update
        _daoFetcher.TourDao().updateTour(oldTour);
        await JsRuntime.InvokeVoidAsync("alert", "Tour '" + TheTour.Variants[0].TourName + "' succesfully updated! Navigating to Sight Manager...");
        NavManager.NavigateTo("SightManager");
    }

    private bool AllFilled()
    {
        // We check if all the info is filled out
        // We go through each variant
        for (int i = 0; i < TheTour.Variants.Count; i++)
        {
            TourVariant variant = TheTour.Variants[i];

            if (variant.Language != null)
            {
                if (string.IsNullOrEmpty(variant.Language.LanguageCode))
                {
                    return false;
                }  
                if (string.IsNullOrEmpty(variant.Language.LanguageName))
                {
                    return false;
                }  
            }
            else
            {
                return false;
            }

            if (string.IsNullOrEmpty(variant.TourName))
            {
                return false;
            }
            
            if (string.IsNullOrEmpty(variant.TourDescription))
            {
                return false;
            }
        }
        return true;
    }

    private void RemoveVariant(int index)
    {
        Language ToAdd = TheTour.Variants[index].Language;
        AddedLanguages.Remove(ToAdd);
        AddedCodes.Remove(ToAdd.LanguageCode);
        AvailableLanguages.Add(ToAdd);
        AvailableCodes.Add(ToAdd.LanguageCode);
        
        disableAddingNewVariants = false;
        VariantAddingMessage = "";
        TheTour.Variants.Remove(TheTour.Variants[index]);
        if (TheTour.Variants.Count == 0)
        {
            DisableCreatingOrUpdatingTour = true;
        }
    }
    
    private async Task UploadImage(InputFileChangeEventArgs e)
    {
        TheTour.ImageBase64 = await imageConverter.UploadedFileToBase64(e.File);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider auth { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDAOFetcher _daoFetcher { get; set; }
    }
}
#pragma warning restore 1591
