#pragma checksum "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a36a6d2d4f9284bfe48ecf7ae2ba36770273ca9a"
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
#line 2 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
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
#line 7 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
     foreach (var tour in Tours)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "li");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "readonly");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                   tour.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => tour.Name = __value, tour.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n            <input type=\"number\" readonly value=\"tour.Sights.Count\">\r\n        \r\n            ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "type", "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                            () => SetTourOnMap(tour.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Edit tour");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-xl-6");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(16);
            __builder.AddAttribute(17, "style", "height: 600px;");
            __builder.AddAttribute(18, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 20 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                                                    zoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ZoomControl", "false");
            __builder.AddAttribute(20, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Radzen.Blazor.RadzenGoogleMapMarker>>(
#nullable restore
#line 20 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                                                                                     Markers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 20 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                                                                                                        new GoogleMapPosition() { Lat = @lat, Lng = @lng }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                                                                                                                                                                        onMapClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(23, "MarkerClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenGoogleMapMarker>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenGoogleMapMarker>(this, 
#nullable restore
#line 20 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                                                                                                                                                                                                  onMarkerClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(24, (__value) => {
#nullable restore
#line 20 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                               MyMap = (Radzen.Blazor.RadzenGoogleMap)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    \r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-xl-6");
            __builder.AddAttribute(28, "hidden", 
#nullable restore
#line 23 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                   hideMarkerProperties

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "<div class=\"signNameField\"><label>Sight name: </label>\r\n        <input placeholder=\"Sight name...\"></div>\r\n    \r\n    ");
            __builder.AddMarkupContent(30, "<div class=\"sightDescriptionField\"><label>Sight description: </label>\r\n        <input placeholder=\"Sight description...\"></div>\r\n    \r\n    ");
            __builder.AddMarkupContent(31, "<div class=\"latitudeField\"><label>Latitude: </label>\r\n        <input type=\"number\" placeholder=\"Latitude...\"></div>\r\n    \r\n    ");
            __builder.AddMarkupContent(32, "<div class=\"longitudeField\"><label>Longitude: </label>\r\n        <input type=\"number\" placeholder=\"Longitude...\"></div>\r\n    \r\n    ");
            __builder.AddMarkupContent(33, "<div class=\"radiusField\"><label>Active radius (meters): </label>\r\n        <input type=\"number\" placeholder=\"Radius...\"></div>\r\n    \r\n        ");
            __builder.AddMarkupContent(34, "<div class=\"imageDisplayField\"><label>Sight image: </label>\r\n            <img src></div>\r\n    \r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "imageUploadField");
            __builder.AddMarkupContent(37, "<label>Upload image: </label>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(38);
            __builder.AddAttribute(39, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    \r\n    ");
            __builder.AddMarkupContent(41, "<div class=\"audioPlayField\"><label>Sight audio: </label>\r\n        <audio controls=\"controls\"><source src></audio></div>\r\n    \r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "audioUploadField");
            __builder.AddMarkupContent(44, "<label>Upload audio: </label>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(45);
            __builder.AddAttribute(46, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                  TogglePlaceNewSightOnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, 
#nullable restore
#line 73 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
                                               buttonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.OpenElement(52, "div");
            __builder.AddContent(53, 
#nullable restore
#line 74 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
      interactionMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\simon\RiderProjects\TravelBuddyWebApp\AuthenticationTest\Pages\Counter.razor"
       
    // Layout
    private bool hideMarkerProperties = true;
    private bool placeNewSightOnClick = false;
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
    
    protected override async Task OnInitializedAsync()
    {
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
        tour1.Sights = Sights;
        
        Sights2.Add(sight3);
        tour2.Sights = Sights2;
        
        Tours.Add(tour1);
        Tours.Add(tour2);
    }

    private async Task SetTourOnMap(int tourId)
    {
        // We clear the current tour
        Markers.Clear();
        
        List<Sight> tourContent = new List<Sight>();
        
        for (int i = 0; i < Tours.Count; i++)
        {
            if (Tours[i].Id == tourId)
            {
                tourContent = Tours[i].Sights;
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
        
            //MyMap.AddMarker(newMarker);
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

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
