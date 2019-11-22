#pragma checksum "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac38314c1e0426404d4e05774ff136acdf6d2f07"
// <auto-generated/>
#pragma warning disable 1591
namespace TimeTracker.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 3 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using TimeTracker.Client;

#line default
#line hidden
#line 8 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using TimeTracker.Client.Shared;

#line default
#line hidden
#line 9 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#line 10 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 2 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
using TimeTracker.Client.Models;

#line default
#line hidden
#line 3 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
using TimeTracker.Client.Services;

#line default
#line hidden
#line 4 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients")]
    public class Clients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col\">\r\n        <h1>Clients</h1>\r\n    </div>\r\n    <div class=\"col text-right\">\r\n        <a href=\"/clients/add\" class=\"btn btn-primary\"><i class=\"oi oi-plus\"></i> Add new</a>\r\n    </div>\r\n</div>\r\n\r\n");
#line 16 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
 if (clients == null)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div>Loading...</div>\r\n");
#line 19 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-striped table-hover");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Client name</th>\r\n                <th>&nbsp;</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#line 30 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
             foreach (var client in clients.Items)
            {

#line default
#line hidden
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#line 33 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
                         client.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "class", "text-right");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "btn-group");
            __builder.AddAttribute(21, "role", "group");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "href", "/clients/" + (
#line 36 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
                                                client.Id

#line default
#line hidden
            ) + "/edit");
            __builder.AddAttribute(25, "class", "btn btn-light");
            __builder.AddMarkupContent(26, "<i class=\"oi oi-pencil\"></i> Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "a");
            __builder.AddAttribute(29, "href", "/clients/" + (
#line 37 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
                                                client.Id

#line default
#line hidden
            ) + "/delete");
            __builder.AddAttribute(30, "class", "btn btn-light text-danger");
            __builder.AddMarkupContent(31, "<i class=\"oi oi-delete\"></i> Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#line 41 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
            }

#line default
#line hidden
            __builder.AddContent(36, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
            __builder.AddContent(39, "    ");
            __Blazor.TimeTracker.Client.Pages.Clients.TypeInference.CreatePager_0(__builder, 40, 41, 
#line 45 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
                   clients

#line default
#line hidden
            , 42, 
#line 45 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
                                     LoadClients

#line default
#line hidden
            );
            __builder.AddMarkupContent(43, "\r\n");
#line 46 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 48 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Clients.razor"
       
    PagedList<ClientModel> clients;

    protected override async Task OnInitializedAsync()
    {
        await LoadClients();
    }

    private async Task LoadClients(int page = 1)
    {
        const int pageSize = 5;
        var url = $"clients?page={page}&size={pageSize}";
        clients = await ApiService.GetAsync<PagedList<ClientModel>>(url);

        // State change not triggered from for loop above
        base.StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiService ApiService { get; set; }
    }
}
namespace __Blazor.TimeTracker.Client.Pages.Clients
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreatePager_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::TimeTracker.Client.Models.PagedList<T> __arg0, int __seq1, global::System.Func<global::System.Int32, global::System.Threading.Tasks.Task> __arg1)
        {
        __builder.OpenComponent<global::TimeTracker.Client.Shared.Pager<T>>(seq);
        __builder.AddAttribute(__seq0, "Model", __arg0);
        __builder.AddAttribute(__seq1, "Loader", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591