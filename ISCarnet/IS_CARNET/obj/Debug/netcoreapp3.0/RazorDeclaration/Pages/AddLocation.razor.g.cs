#pragma checksum "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddLocation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18745f0fbdebc94c59426efd49427c2196bac3f4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace IS_CARNET.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using IS_CARNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using IS_CARNET.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using DataBaseLibrary.DTOs.PastExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddLocation.razor"
using IS_CARNET.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddLocation.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addlocation")]
    public partial class AddLocation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "D:\dev\Github\ISCarnet\ISCarnet\IS_CARNET\Pages\AddLocation.razor"
               

            async Task showError(string error)
            {
                await JSRuntime.InvokeVoidAsync("createError", error);
                NavigationManager.NavigateTo("/");
            }

            private LocationDTO dto = new LocationDTO();
            string name = String.Empty;

            async Task ShowAlert(string error)
            {
                await JSRuntime.InvokeVoidAsync("createSuccess", error);

            }

            // FUNCTIA DE SUBMIT
            private async Task SubmitLocation()
            {
                name = String.Empty;
                HttpClient Http = new HttpClient();
                HttpContent content = new StringContent(JsonConvert.SerializeObject(dto), Encoding.UTF8, "application/json");
                HttpResponseMessage h = await Http.PostAsync("https://localhost:44369/api/Location", content);
                var responseJSON = h.Content.ReadAsStringAsync().Result;
                LocationDTO ex = JsonConvert.DeserializeObject<LocationDTO>(responseJSON);
                name = ex.LocationName + " ( " + ex.Latitude + ", " + ex.Longitude + ")";
                ShowAlert("Locatia " + name + " a fost adaugata cu succes!");
            }

        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591