#pragma checksum "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58faf834a0ae5bd1d33edaf0433fe921df6eafe2"
// <auto-generated/>
#pragma warning disable 1591
namespace GloboTicket.TicketManagement.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using GloboTicket.TicketManagement.App.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eventoverview")]
    public partial class EventOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Event Overview</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "m-2 d-flex justify-content-end");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
                      AddNewEvent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "mr-1");
            __builder.AddContent(6, "Add event");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
                      ExportEvents

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Export events");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
 if (Events == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddMarkupContent(13, "<thead><tr><th></th>\r\n            <th>Event name</th>\r\n            <th>Event date</th>\r\n            <th></th></tr></thead>\r\n    ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 28 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
         foreach (var ev in Events)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", 
#nullable restore
#line 32 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
                            ev.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "class", "event-image");
            __builder.AddAttribute(20, "alt", "ImageUrl");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "class", "event-name");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
                                    ev.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "class", "event-date");
            __builder.AddContent(28, 
#nullable restore
#line 34 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
                                    ev.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "td");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 36 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
                           $"eventdetails/{ev.EventId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "class", "event-purchase-button btn");
            __builder.AddMarkupContent(34, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Projects\Tests\Backend\EN\GloboTicket.TicketManagement\GloboTicket.TicketManagement.App\Pages\EventOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
