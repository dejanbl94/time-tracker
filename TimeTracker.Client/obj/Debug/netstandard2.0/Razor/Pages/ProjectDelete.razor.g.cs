#pragma checksum "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a4a9ce5d89e641b2484b0310e24d053b5d64013"
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
#line 2 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
using TimeTracker.Client.Models;

#line default
#line hidden
#line 3 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
using TimeTracker.Client.Services;

#line default
#line hidden
#line 4 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects/{id:long}/delete")]
    public class ProjectDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Delete project ");
            __builder.AddContent(2, 
#line 8 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
                     project == null ? string.Empty : project.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.AddMarkupContent(4, "<div class=\"alert alert-warning\">Are you sure you want to delete this project?</div>\r\n\r\n");
#line 12 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
 if (!string.IsNullOrWhiteSpace(errorMessage))
{

#line default
#line hidden
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "alert alert-danger");
            __builder.AddContent(8, 
#line 14 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
                                     errorMessage

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#line 15 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "class", "btn btn-danger");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 17 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
                                                       DeleteProject

#line default
#line hidden
            ));
            __builder.AddContent(15, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.AddMarkupContent(17, "<a href=\"/projects\" class=\"btn btn-link\">Cancel</a>");
        }
        #pragma warning restore 1998
#line 20 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\ProjectDelete.razor"
       
    [Parameter] public long Id { get; set; }
    private ProjectModel project;
    private string errorMessage;

    protected override async Task OnInitializedAsync()
    {
        await LoadProject();
    }

    private async Task LoadProject()
    {
        var url = $"projects/{Id}";
        project = await ApiService.GetAsync<ProjectModel>(url);
    }

    private async Task DeleteProject()
    {
        if (await ApiService.DeleteAsync($"projects/{project.Id}"))
        {
            NavigationManager.NavigateTo("/projects");
        }
        else
        {
            errorMessage = "Error saving project";
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiService ApiService { get; set; }
    }
}
#pragma warning restore 1591
