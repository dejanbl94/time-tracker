#pragma checksum "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eba1750bc31963fe9801a9eea9c06329509154d3"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Users.razor"
using TimeTracker.Client.Models;

#line default
#line hidden
#line 3 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Users.razor"
using TimeTracker.Client.Services;

#line default
#line hidden
#line 4 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Users.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 50 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Users.razor"
       
    PagedList<UserModel> users;

    protected override async Task OnInitializedAsync()
    {
        await LoadUsers();
    }

    private async Task LoadUsers(int page = 1)
    {
        const int pageSize = 5;
        var url = $"users?page={page}&size={pageSize}";
        users = await ApiService.GetAsync<PagedList<UserModel>>(url);

        // State change not triggered from for loop above
        base.StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiService ApiService { get; set; }
    }
}
#pragma warning restore 1591
