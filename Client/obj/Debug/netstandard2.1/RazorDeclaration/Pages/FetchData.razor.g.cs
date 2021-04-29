// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorEpic.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using BlazorEpic.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blazor src\BlazorEpic\Client\_Imports.razor"
using BlazorEpic.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor src\BlazorEpic\Client\Pages\FetchData.razor"
using BlazorEpic.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Blazor src\BlazorEpic\Client\Pages\FetchData.razor"
       

    private WeatherForecast[] forecasts;
    string userdata = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        userdata = await jsr.InvokeAsync<string>("localStorage.getItem", "user").ConfigureAwait(false);
        if (!string.IsNullOrWhiteSpace(userdata))
        {
            var dataArray = userdata.Split(';', 2);
            var requestMsg = new HttpRequestMessage(HttpMethod.Get, "/api/weatherforecast");
            requestMsg.Headers.Add("Authorization", "Bearer " + dataArray[1]);
            var response = await Http.SendAsync(requestMsg);
            if (response.IsSuccessStatusCode)
                forecasts = await response.Content.ReadFromJsonAsync<WeatherForecast[]>();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
