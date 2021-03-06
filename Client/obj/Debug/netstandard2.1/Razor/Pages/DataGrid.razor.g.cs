#pragma checksum "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "627fa147bdb8d8b27d1769c305cf5c196ab6de14"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
using BlazorEpic.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
using BlazorEpic.Client.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/datagrid")]
    public partial class DataGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Customers</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
 if (custs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
}

#line default
#line hidden
#nullable disable
            __Blazor.BlazorEpic.Client.Pages.DataGrid.TypeInference.CreateDataGridComponent_0(__builder, 3, 4, "table-responsive", 5, "table table-hover table-striped", 6, "id", 7, "id", 8, 
#nullable restore
#line 12 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
                                                                                                                                                  custs

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "form");
            __builder.AddAttribute(11, "class", "mt-5");
            __builder.AddAttribute(12, "onsubmit", "return false;");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group form-check");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "checkbox");
            __builder.AddAttribute(19, "class", "form-check-input");
            __builder.AddAttribute(20, "id", "vipCheck");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
                                                                                   customer.vip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.vip = __value, customer.vip));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<label class=\"form-check-label\" for=\"vipCheck\">VIP?</label>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "input-group input-group-md mb-2");
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, "<span class=\"input-group-text\">Name</span>\r\n        ");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "autocomplete", "off");
            __builder.AddAttribute(34, "required", true);
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
                                                                                         customer.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.name = __value, customer.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "input-group input-group-md mb-2");
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.AddMarkupContent(42, "<span class=\"input-group-text\">Address</span>\r\n        ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "type", "text");
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "autocomplete", "off");
            __builder.AddAttribute(47, "required", true);
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
                                                                                         customer.address

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.address = __value, customer.address));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "input-group input-group-md mb-2");
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.AddMarkupContent(55, "<span class=\"input-group-text\">Zip</span>\r\n        ");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "text");
            __builder.AddAttribute(58, "class", "form-control");
            __builder.AddAttribute(59, "autocomplete", "off");
            __builder.AddAttribute(60, "required", true);
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
                                                                                         customer.zip

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.zip = __value, customer.zip));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-success");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
                                                  Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Blazor src\BlazorEpic\Client\Pages\DataGrid.razor"
       

    private List<CustomerDataGrid> custs;
    private CustomerDataGrid customer = new CustomerDataGrid();

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();

        custs = await Http.GetFromJsonAsync<List<CustomerDataGrid>>("/api/customers");
    }

    private async Task Add()
    {
        using (var msg = await Http.PostAsJsonAsync<CustomerDataGrid>("/api/customersdatagrid", customer, System.Threading.CancellationToken.None))
        {
            if (msg.IsSuccessStatusCode)
            {
                custs.Add(await msg.Content.ReadFromJsonAsync<CustomerDataGrid>());
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
namespace __Blazor.BlazorEpic.Client.Pages.DataGrid
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateDataGridComponent_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::System.Collections.Generic.List<TItem> __arg4)
        {
        __builder.OpenComponent<global::BlazorEpic.Client.Components.DataGridComponent<TItem>>(seq);
        __builder.AddAttribute(__seq0, "ParentClassName", __arg0);
        __builder.AddAttribute(__seq1, "TableClassName", __arg1);
        __builder.AddAttribute(__seq2, "HideColumns", __arg2);
        __builder.AddAttribute(__seq3, "DataKeyColumn", __arg3);
        __builder.AddAttribute(__seq4, "Items", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
