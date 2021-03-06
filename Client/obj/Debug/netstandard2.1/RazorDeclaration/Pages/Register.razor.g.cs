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
#line 2 "C:\Blazor src\BlazorEpic\Client\Pages\Register.razor"
using BlazorEpic.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Blazor src\BlazorEpic\Client\Pages\Register.razor"
       
    RegModel reg = new RegModel();
    string message = string.Empty, login = string.Empty;
    bool isDisabled = false;

    private async Task OnValid()
    {
        isDisabled = true;
        using (var msg = await Http.PostAsJsonAsync<RegModel>("/api/auth/register", reg, System.Threading.CancellationToken.None))
        {
            if (msg.IsSuccessStatusCode)
            {
                LoginResult result = await msg.Content.ReadFromJsonAsync<LoginResult>();
                message = result.message;
                if (result.success)
                {
                    message += " Please LOGIN to continue.";
                    login = "Click here to LOGIN.";
                }
                else
                    isDisabled = false;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
