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
