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
#line 2 "C:\Blazor src\BlazorEpic\Client\Pages\DataRepeater.razor"
using BlazorEpic.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor src\BlazorEpic\Client\Pages\DataRepeater.razor"
using BlazorEpic.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor src\BlazorEpic\Client\Pages\DataRepeater.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datarepeater")]
    public partial class DataRepeater : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Blazor src\BlazorEpic\Client\Pages\DataRepeater.razor"
       

    private List<Customer> custs;
    private Customer newcust = new Customer();

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        custs = await Http.GetFromJsonAsync<List<Customer>>("/api/customers");
    }

    private async Task Add()
    {
        using (var msg = await Http.PostAsJsonAsync<Customer>("/api/customers", newcust, System.Threading.CancellationToken.None))
        {
            if (msg.IsSuccessStatusCode)
            {
                custs.Add(await msg.Content.ReadFromJsonAsync<Customer>());
                //StateHasChanged();
            }
        }
    }

    private async Task Save(ChangeEventArgs e, Customer cust, string propField)
    {
        PropertyInfo pinfo = typeof(Customer).GetProperty(propField);
        pinfo.SetValue(cust, e.Value);

        using (var msg = await Http.PutAsJsonAsync<Customer>($"/api/customers/{cust.id}", cust, System.Threading.CancellationToken.None))
        {
            if (msg.IsSuccessStatusCode)
            {
                //StateHasChanged();
            }
            else
            {
                // DO SOMETHING
            }
        }
    }

    private async Task Delete(string id)
    {
        using (var msg = await Http.DeleteAsync($"/api/customers/{id}"))
        {
            if (msg.IsSuccessStatusCode)
            {
                int i;
                for (i = 0; i < custs.Count && custs[i].id != id; i++) ;
                custs.RemoveAt(i);
                //StateHasChanged();
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