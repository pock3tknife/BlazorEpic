#pragma checksum "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61d460461f12eb32de0699d6bc2c667f5f3e290e"
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
#line 1 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using BlazorEpic.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\_Imports.razor"
using BlazorEpic.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
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
            __builder.AddMarkupContent(0, "<h3>Register</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, 
#nullable restore
#line 7 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
    message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "p");
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "href", "/login");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
                     login

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
                 reg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
                                     OnValid

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "style", "max-width:500px;");
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "mb-2");
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "placeholder", "Enter Email");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
                                                     reg.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reg.email = __value, reg.email))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => reg.email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "mb-2");
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "type", "password");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "placeholder", "Enter Password");
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
                                                                     reg.password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reg.password = __value, reg.password))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => reg.password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "mb-2");
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "type", "password");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "placeholder", "Confirm Password");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
                                                                     reg.confirmpwd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => reg.confirmpwd = __value, reg.confirmpwd))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => reg.confirmpwd));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "mb-2 text-right");
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenElement(57, "button");
                __builder2.AddAttribute(58, "class", "btn btn-secondary");
                __builder2.AddAttribute(59, "disabled", 
#nullable restore
#line 23 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
                                                     isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(60, "register");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\rLawrence\source\repos\BlazorEpic\Client\Pages\Register.razor"
       
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