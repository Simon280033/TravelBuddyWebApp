#pragma checksum "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c787c4ad9b8f273654dbb7731fc5ecd9b9fa968"
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
#line 2 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
using AuthenticationTest.Data.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "ul");
#nullable restore
#line 7 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
         foreach (Tour tour in Tours)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "li");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "readonly");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                       tour.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tour.Name = __value, tour.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n                <input type=\"number\" readonly value=\"tour.Sights.Count\">\r\n            \r\n                ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "type", "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                () => SetTourOnMap(tour.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Edit tour");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    \r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddContent(13, 
#nullable restore
#line 18 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
          headerMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-xl-6");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(19);
            __builder.AddAttribute(20, "style", "height: 600px;");
            __builder.AddAttribute(21, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 22 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                        zoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "ZoomControl", "false");
            __builder.AddAttribute(23, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Radzen.Blazor.RadzenGoogleMapMarker>>(
#nullable restore
#line 22 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                                                         Markers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 22 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                                                                            new GoogleMapPosition() { Lat = @lat, Lng = @lng }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                                                                                                                                            onMapClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "MarkerClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenGoogleMapMarker>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenGoogleMapMarker>(this, 
#nullable restore
#line 22 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                                                                                                                                                                      onMarkerClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(27, (__value) => {
#nullable restore
#line 22 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                   MyMap = (Radzen.Blazor.RadzenGoogleMap)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        \r\n        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-xl-6");
            __builder.AddAttribute(31, "hidden", 
#nullable restore
#line 25 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                       hideMarkerProperties

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "languageChoice");
            __builder.AddMarkupContent(34, "<b><label for=\"languageCodes\">Language:</label></b>\r\n                ");
            __builder.OpenElement(35, "select");
            __builder.AddAttribute(36, "id", "languageCodes");
            __builder.AddAttribute(37, "name", "languageCodes");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                       languageCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => languageCode = __value, languageCode));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 29 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                     foreach (string language in languageCodes)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "option");
            __builder.AddContent(41, 
#nullable restore
#line 31 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                 language

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            \r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "signNameField");
            __builder.AddMarkupContent(45, "<div><label>Sight name: </label></div>\r\n                ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "placeholder", "Sight name...");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                selectedSight.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedSight.Name = __value, selectedSight.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "sightDescriptionField");
            __builder.AddMarkupContent(53, "<div><label>Sight description: </label></div>\r\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "placeholder", "Sight description...");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                       selectedSight.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedSight.Description = __value, selectedSight.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "latitudeField");
            __builder.AddMarkupContent(61, "<div><label>Latitude: </label></div>\r\n                ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "number");
            __builder.AddAttribute(64, "placeholder", "Latitude...");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                            selectedSight.Latitude

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedSight.Latitude = __value, selectedSight.Latitude, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "longitudeField");
            __builder.AddMarkupContent(70, "<div><label>Longitude: </label></div>\r\n                ");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "type", "number");
            __builder.AddAttribute(73, "placeholder", "Longitude...");
            __builder.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                             selectedSight.Longitude

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedSight.Longitude = __value, selectedSight.Longitude, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n            ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "radiusField");
            __builder.AddMarkupContent(79, "<div><label>Active radius (meters): </label></div>\r\n                ");
            __builder.OpenElement(80, "input");
            __builder.AddAttribute(81, "type", "number");
            __builder.AddAttribute(82, "placeholder", "Radius...");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                          selectedSight.RadiusInMeters

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedSight.RadiusInMeters = __value, selectedSight.RadiusInMeters, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n            ");
            __builder.AddMarkupContent(86, "<div class=\"imageDisplayField\"><div><label>Sight image: </label></div>\r\n                <img src></div>\r\n\r\n            ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "imageUploadField");
            __builder.AddMarkupContent(89, "<div><label>Upload image: </label></div>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(90);
            __builder.AddAttribute(91, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n            ");
            __builder.AddMarkupContent(93, "<div class=\"audioPlayField\"><div><label>Sight audio: </label></div>\r\n                <audio controls=\"controls\"><source src></audio></div>\r\n\r\n            ");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "audioUploadField");
            __builder.AddMarkupContent(96, "<div><label>Upload audio: </label></div>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(97);
            __builder.AddAttribute(98, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\r\n    ");
            __builder.OpenElement(100, "button");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                      TogglePlaceNewSightOnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "hidden", 
#nullable restore
#line 103 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                           hideAddMarkerButton

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(103, 
#nullable restore
#line 103 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
                                                                                 buttonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.OpenElement(105, "div");
            __builder.AddContent(106, 
#nullable restore
#line 104 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
          interactionMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\simon\RiderProjects\AuthenticationTest\AuthenticationTest\Pages\Counter.razor"
           
        // Layout
        private string headerMessage = "Select Tour to edit";
        private bool hideMarkerProperties = true;
        private bool placeNewSightOnClick = false;
        private bool hideAddMarkerButton = true;
        private string interactionMessage = "Click on a marker to edit its properties";
        private string buttonText = "Place new sight";
        
        private List<RadzenGoogleMapMarker> Markers = new List<RadzenGoogleMapMarker>();
        
        // Map properties
        private RadzenGoogleMap MyMap = new RadzenGoogleMap();
        private int zoom = 3; // Zoom to start out with
        
        // Map interaction results
        private string clickedPosition = "";
        private double lat = 42.6977;
        private double lng = 23.3219;
        
        // Company Tours and content
        private List<Tour> Tours = new List<Tour>();
        private int SelectedTourIndex;
        
        // Selected marker attributes
        Sight selectedSight = new Sight();
        List<Sight> sightLanguageVariants = new List<Sight>();
        private string languageCode = "EN";
        private List<string> languageCodes = new List<string>();

        protected override async Task OnInitializedAsync()
        {
            languageCodes.Add("EN");
            languageCodes.Add("DA");
            languageCodes.Add("DE");
            GetToursForCompany(0);
        }
        
        private void TogglePlaceNewSightOnClick()
        {
            placeNewSightOnClick = !placeNewSightOnClick;
            if (placeNewSightOnClick)
            {
                interactionMessage = "Click on map to create new sight";
                buttonText = "Cancel placing new sight";
            } 
            else 
            {
                interactionMessage = "Click on a marker to edit its properties";
                buttonText = "Place new sight";
            }
        }

        private void GetToursForCompany(int tourId)
        {
            MockSeedTours();
        }

        private void MockSeedTours()
        {
            List<Sight> Sights = new List<Sight>();
            List<Sight> Sights2 = new List<Sight>();

            Tour tour1 = new Tour();
            tour1.Id = 1;
            Tour tour2 = new Tour();
            tour2.Id = 2;

            Sight sight1 = new Sight();
            sight1.Name = "Sight 1";
            sight1.Latitude = 56.158799668496535;
            sight1.Longitude = 10.186587577308952;
            
            Sight sight2 = new Sight();
            sight2.Name = "Sight 2";
            sight2.Latitude = 56.14918878549672;
            sight2.Longitude = 10.185278848567933;
            
            Sight sight3 = new Sight();
            sight3.Name = "Sight 3";
            sight3.Latitude = 58.14918878549672;
            sight3.Longitude = 12.185278848567933;
            
            Sights.Add(sight1);
            Sights.Add(sight2);

            tour1.Name = "Tour 1";
            tour2.Name = "Tour 2";
            List<List<Sight>> sightWrapper = new List<List<Sight>>();
            sightWrapper.Add(Sights);
            tour1.Sights = sightWrapper;
            
            Sights2.Add(sight3);
            List<List<Sight>> sightWrapper2 = new List<List<Sight>>();
            sightWrapper2.Add(Sights2);
            tour2.Sights = sightWrapper2;
            
            Tours.Add(tour1);
            Tours.Add(tour2);
        }

        private async Task SetTourOnMap(int tourId)
        {
            // We clear the current tour
            Markers.Clear();
            
            // We show the button
            hideAddMarkerButton = false;
            
            List<Sight> tourContent = new List<Sight>();
            
            for (int i = 0; i < Tours.Count; i++)
            {
                if (Tours[i].Id == tourId)
                {
                    tourContent = Tours[i].Sights[0];
                    // We set the tour name in header
                    headerMessage = "Editing Tour '" + Tours[i].Name + "'";
                    // And the index
                    SelectedTourIndex = i;
                    break;
                }
            }
            
            for (int i = 0; i < tourContent.Count; i++)
            {
                Console.WriteLine("Setting sight: " + tourContent[i].Name);
                GoogleMapPosition newPos = new GoogleMapPosition
                {
                    Lat = tourContent[i].Latitude,
                    Lng = tourContent[i].Longitude
                };
                
                RadzenGoogleMapMarker newMarker = new RadzenGoogleMapMarker()
                {
                    Position = newPos,
                    Label = tourContent[i].Name
                };

                Markers.Add(newMarker);
            }
        }

        private void onMapClick(GoogleMapClickEventArgs args)
        {
            if (!placeNewSightOnClick)
            {
              hideMarkerProperties = true;
              return;
            }
            
            // We set the map properties
            zoom = 15;
            lat = args.Position.Lat;
            lng = args.Position.Lng;

            RadzenGoogleMapMarker newMarker = new RadzenGoogleMapMarker();
            newMarker.Position = args.Position;
            newMarker.Title = "test";
            newMarker.Label = "test2";
            
            Markers.Add(newMarker);
            
            clickedPosition = $"Map clicked LAT : {args.Position.Lat}, LNG : {args.Position.Lng} Zoom: " + MyMap.Zoom;
        }
        
        private void onMarkerClick(RadzenGoogleMapMarker args)
        {
                if (placeNewSightOnClick)
                {
                  return;
                }
                
            hideMarkerProperties = false;
            Console.WriteLine("Label: " + args.Label + ", Title: " + args.Title);
            clickedPosition = $"Map {args.Title} clicked LAT : {args.Position.Lat}, LNG : {args.Position.Lng}";
            
            // We set its info
            Tour selectedTour = Tours[SelectedTourIndex];
            for (int i = 0; i < selectedTour.Sights.Count; i++)
            {
                for (int j = 0; j < selectedTour.Sights[i].Count; j++)
                {
                    Console.WriteLine("Name: " + selectedTour.Sights[i][j].Name + ", args name: " + args.Label);
                    if (selectedTour.Sights[i][j].Name.Equals(args.Label))
                    {
                        selectedSight = Tours[SelectedTourIndex].Sights[i][j];
                        break;
                    }
                }
            }
            
        // remove the marker (now)
        /*
            for (int i = 0; i < Markers.Count; i++) 
            {
                if (Markers[i].Label.Equals(args.Label))
                {
                    Markers.Remove(Markers[i]);
                    break;
                }
            }
            */
        }

        private void SetSelectedMarkerAttributes()
        {
            
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
