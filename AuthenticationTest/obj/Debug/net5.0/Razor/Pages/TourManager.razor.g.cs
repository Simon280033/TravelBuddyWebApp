#pragma checksum "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd22a2346cf84d2b026b2dfbb5c3fc26293760f"
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
#line 2 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
using AuthenticationTest.Data.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
using ImageConverter = AuthenticationTest.Data.Converters.Concrete.ImageConverter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
using AuthenticationTest.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TourManager")]
    public partial class TourManager : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 10 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
     HeaderText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "imageDisplayField");
            __builder.AddMarkupContent(5, "<div><label>Sight image: </label></div>\r\n    ");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "width", "300");
            __builder.AddAttribute(8, "height", "300");
            __builder.AddAttribute(9, "src", "data:image/*;base64," + (
#nullable restore
#line 16 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                            TheTour.ImageBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "imageUploadField");
            __builder.AddMarkupContent(13, "<div><label>Upload image: </label></div>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(14);
            __builder.AddAttribute(15, "id", "image-picker");
            __builder.AddAttribute(16, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                            UploadImage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "accept", "image/*");
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n\r\n");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "color:red");
            __builder.AddContent(21, 
#nullable restore
#line 27 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                        MissingInfoErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "style", "color:red");
            __builder.AddContent(25, 
#nullable restore
#line 28 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                        VariantAddingMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                  ToggleLanguageChoiceVisibility

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "disabled", 
#nullable restore
#line 29 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                             disableAddingNewVariants

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(30, "Add new language variant");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row");
            __builder.AddAttribute(34, "hidden", 
#nullable restore
#line 31 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                          hideLanguageChoice

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-xl-6");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "languageChoice");
            __builder.AddMarkupContent(39, "<b><label for=\"languageCodes\">Language:</label></b>\r\n            ");
            __builder.OpenElement(40, "select");
            __builder.AddAttribute(41, "id", "languageCodes");
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                  TourLanguageChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "name", "languageCodes");
#nullable restore
#line 36 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                 foreach (Language language in Languages)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "option");
            __builder.AddContent(45, 
#nullable restore
#line 38 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                             language.LanguageName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                        () => AddRow()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "hidden", 
#nullable restore
#line 48 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
              hideVariantOverview

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 49 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
     for (int i = 0; i < TheTour.Variants.Count; i++)
    {
        int index = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "style", "border: thin solid black");
            __builder.AddMarkupContent(57, "<div>Language:</div>\r\n            ");
            __builder.OpenElement(58, "div");
            __builder.AddContent(59, 
#nullable restore
#line 54 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                  TheTour.Variants[index].Language.LanguageName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.AddMarkupContent(61, "<div>Name:</div>\r\n            ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "id", "nameInput@index");
            __builder.AddAttribute(64, "placeholder", "Tour" + " name" + " in" + " " + (
#nullable restore
#line 56 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                                   TheTour.Variants[index].Language.LanguageName

#line default
#line hidden
#nullable disable
            ) + "...");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                                                                                                   TheTour.Variants[index].TourName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TheTour.Variants[index].TourName = __value, TheTour.Variants[index].TourName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.AddMarkupContent(68, "<div>Description:</div>\r\n            ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "id", "descInput@index");
            __builder.AddAttribute(71, "placeholder", "Tour" + " description" + " in" + " " + (
#nullable restore
#line 58 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                                          TheTour.Variants[index].Language.LanguageName

#line default
#line hidden
#nullable disable
            ) + "...");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                                                                                                          TheTour.Variants[index].TourDescription

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TheTour.Variants[index].TourDescription = __value, TheTour.Variants[index].TourDescription));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(74, "div");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                        () => RemoveVariant(index)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Remove variant");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\r\n");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "disabled", 
#nullable restore
#line 67 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                 DisableCreatingOrUpdatingTour

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                                          () => CreateOrUpdateTour()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, 
#nullable restore
#line 67 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
                                                                                                       CreateOrUpdateButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\TourManager.razor"
       
    // Converters
    private IImageConverter imageConverter = new ImageConverter();
    
    // Bools for showing/hiding
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

    protected override async Task OnInitializedAsync()
    {
        Languages = _daoFetcher.LanguageDao().GetLanguages();
        
        selectedTourLanguageCode = Languages[0].LanguageCode;
        
        TheTour = new Tour
        {
            Variants = new List<TourVariant>(),
            Id = TheTour.Variants.Count,
            ImageBase64 = "iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAJ1BMVEXt7e3V1dXW1tbm5ubs7Ozg4ODc3NzS0tLw8PDo6OjZ2dnj4+Pe3t5T9WAhAAAEmklEQVR4nO2ciXKsIBBFsQUB9f+/9+EuKjPEpe2X3FOVSTJlAmdaWRpUKQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAP8Pbnh9mr4Uza+nnSpbChTTy0M/hNfKeNeXyIshW/BReaVZ4+h8zSY3lESG008rz+a30LIqFpbYDa1huxC1qovQDHAbUuG5DF3Tl8cmORdTs/Ua9VxuzUHXaA+WnsnQD90EUa1ZPlRtChoMuRobs5w0PLiGphJ5YlgNxVnGHrgeTlOuIkdD4imtx/B+qKNhzThOLF8xJE5D+4ohT2k9MLwZGD4ADG8Ghg8Aw5uB4QPINRxqdH14J9awmyG7summ5tfqJthQO1NY21wtUrKh7zJW9mqWTLLhcPDV9INYQ6XHqhXGXaqcXEM1L2/4S2k5qYbaNfP61LXEnFRDpWhJize/MIbrEAau1E6qoV75FfZKwlqmoVYmWiWmUp1ex5VpqKIQdhdkOG9/l2EcwuDYnu4UZRrq7frihSVOgYahKm2xUzw9eBNoqJy3O8Pi9CRDoqGqhv0+UQzpbKco0bAs9iEMVOeKlGeoVWpH0bnBmzxD5VMbbuhUJQUapkJI9tR5Ks+w+bBnqnRxXqr7razMx30d8gzTu4nI1nE1O8HWfkl0SDN0TXq7lKUwyYgqqrvDw9uftq1JM9RftoP57eF09PYaYYbOpNRG6vUIXLtqrH6bPk+FGX4LYdcpLripVSJbupSjMMNvISyiwZsu5sFdOlsly1Afa8Xn6Xzw9N96geTAXJShazMMi3I4WOsmejtlIMowbws4jRmbOOA2tV1dkGFoGbMMu9O0q24VZzpSSziCDKfttV8iSGOSv9wODRKjVkGGrs7Z/G0b1w/XdDy6Cz/b8rBIQYal3U7sj6j70WhoR+12AEt02CVKMdTpWVNk0TeZ4as5SgM0R8NTIYZDnTMYL7bjjpOO8uJCDFVeCKebX1Kt7tEcQ4xhXgjH/dPJgw96DCmGuyz3MdQ1pc4nj632QRRi+HXWNNJNghvz4cPwO0Uhht9nTeMfhqp+PGCf0BBimBnC8a8/fRzNdpFKhmFuCDOoZcYwa9aUyXZFXIThrTfO0qbHeN1QL+/exKbHeN1QZc6a8tnMMV431GHWdPM9s3W07/Z1Q+XKgxXfS8RZqfcN84bcP4LW6zfvG2YOuX9EGwavk9HrhvqBEEYbNt82/LTWdIFVVuptwweuwp6l23/bUD/zHJfVbsa3Df3nmcJpltP0bcPwziNR9GJaGqUbU91LG1g9BeN9w2v3GiSR0x8+9AAQSWOap4Hhzfx6Q1eNzxdiKU1F6yFshn0ILdPjcPoUCU2GLGVOeVG2p4u5aZWK68Lw/Vkavswdt/jmFDiN7A9WNB5hSf3WhoPpFKXrd9tmCi63irA8sI3mb+f2F58xvDF/n6VIwytXCFW/2Y7zyZ6TJVv3pPpnxPGzW655Ere9a+tpqLAVp2D/BNOa1TG54+1JfMXW4JDhDeCM9r5kwL+k92d4/vNFBAEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAD4Y/wDpoY2HBKwqLIAAAAASUVORK5CYII=",
            CompanyId = 0,
            Sights = null
        };

        if (TheTour.Id == 0)
        {
            CreateOrUpdateButtonText = "Create Tour with language variants";
            HeaderText = "Create new tour";
        }
        else
        {
            CreateOrUpdateButtonText = "Update Tour and language variants";
            HeaderText = "Update tour";
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
        // We remove the available languages from the list
        // If it is the last language, we disable
        if (Languages.Count == 1)
        {
            disableAddingNewVariants = true;
            VariantAddingMessage = "No more languages available to add variants for!";
        }
        else
        {
            for (int i = 0; i < Languages.Count; i++)
            {
                if (Languages[i].LanguageCode.Equals(selectedTourLanguageCode))
                {
                    Languages.Remove(Languages[i]);
                    break;
                }
            }
        }
        selectedTourLanguageCode = Languages[0].LanguageCode;
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
        // We set it as the selected
        Language languageChosen = (Language) e.Value;
        selectedTourLanguageCode = languageChosen.LanguageCode;
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
        // If the Tour ID is 0, we are creating
        if (TheTour.Id == 0)
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
        await JsRuntime.InvokeVoidAsync("alert", "Tour succesfully created! Navigating to Sight Manager...");
        NavManager.NavigateTo("Counter");
    }

    private void UpdateTour()
    {
        
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
        if (!Languages.Contains(ToAdd))
        {
            if (disableAddingNewVariants)
            {
                Languages.Clear();
            }
            Languages.Add(ToAdd);
        }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDAOFetcher _daoFetcher { get; set; }
    }
}
#pragma warning restore 1591
