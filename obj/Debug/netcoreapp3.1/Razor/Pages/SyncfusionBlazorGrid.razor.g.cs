#pragma checksum "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718a1316974a7fc35c30e60996758f96bc229822"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorEpic.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using BlazorEpic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using BlazorEpic.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Blazor repo\blazor-repo\BlazorEpic\_Imports.razor"
using Syncfusion.EJ2.Blazor.Grids;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/syncfusionGridDemo")]
    public partial class SyncfusionBlazorGrid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Syncfusion Blazor Grid</h3>\r\n\r\n");
            __Blazor.BlazorEpic.Pages.SyncfusionBlazorGrid.TypeInference.CreateEjsGrid_0(__builder, 1, 2, 
#nullable restore
#line 5 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                      Orders

#line default
#line hidden
#nullable disable
            , 3, 
#nullable restore
#line 5 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                           true

#line default
#line hidden
#nullable disable
            , 4, 
#nullable restore
#line 5 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                                               true

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 5 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
            , 6, (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.EJ2.Blazor.Grids.GridPageSettings>(8);
                __builder2.AddAttribute(9, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                5

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.EJ2.Blazor.Grids.GridColumns>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.EJ2.Blazor.Grids.GridColumn>(14);
                    __builder3.AddAttribute(15, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                            nameof(Order.OrderID)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "HeaderText", "Order ID");
                    __builder3.AddAttribute(17, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.Grids.TextAlign>(
#nullable restore
#line 8 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                                                                    TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.EJ2.Blazor.Grids.GridColumn>(20);
                    __builder3.AddAttribute(21, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                            nameof(Order.CustomerID)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "HeaderText", "Customer Name");
                    __builder3.AddAttribute(23, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.Grids.TextAlign>(
#nullable restore
#line 9 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                                                                            TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.EJ2.Blazor.Grids.GridColumn>(26);
                    __builder3.AddAttribute(27, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                            nameof(Order.OrderDate)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "HeaderText", "Order Date");
                    __builder3.AddAttribute(29, "Format", "d");
                    __builder3.AddAttribute(30, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.Grids.ColumnType>(
#nullable restore
#line 10 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                                                                              ColumnType.Date

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.Grids.TextAlign>(
#nullable restore
#line 10 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                                                                                                          TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n        ");
                    __builder3.OpenComponent<Syncfusion.EJ2.Blazor.Grids.GridColumn>(34);
                    __builder3.AddAttribute(35, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                            nameof(Order.Freight)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "HeaderText", "Freight");
                    __builder3.AddAttribute(37, "Format", "C2");
                    __builder3.AddAttribute(38, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.EJ2.Blazor.Grids.TextAlign>(
#nullable restore
#line 11 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
                                                                                               TextAlign.Right

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Width", "120");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Blazor repo\blazor-repo\BlazorEpic\Pages\SyncfusionBlazorGrid.razor"
       
    public List<Order> Orders { get; set; }

    protected override void OnInitialized()
    {
        Orders = Enumerable.Range(1, 75).Select(x => new Order()
        {
            OrderID = 100 + x,
            CustomerID = (new string[] { "Emilia Tan", "Lucy Heartfilia", "Elizabeth Liones", "Momo Yaoyorozu", "Orihime Inoue" })[new Random().Next(5)],
            Freight = 2.1 * x,
            OrderDate = DateTime.Now.AddDays(-x)
        }).ToList();
    }

    public class Order
    {
        public int? OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Freight { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorEpic.Pages.SyncfusionBlazorGrid
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateEjsGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.EJ2.Blazor.Grids.EjsGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "AllowPaging", __arg1);
        __builder.AddAttribute(__seq2, "AllowSorting", __arg2);
        __builder.AddAttribute(__seq3, "AllowFiltering", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
