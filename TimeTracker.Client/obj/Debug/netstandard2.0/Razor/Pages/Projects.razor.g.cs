#pragma checksum "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ccca799b7bd63262ab0749bd80158ed3bfd8fd"
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
#line 2 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
using TimeTracker.Client.Models;

#line default
#line hidden
#line 3 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
using TimeTracker.Client.Services;

#line default
#line hidden
#line 4 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
           [Authorize]

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects")]
    public class Projects : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\">\r\n    <div class=\"col\">\r\n        <h1>Projects</h1>\r\n    </div>\r\n    <div class=\"col text-right\">\r\n        <a href=\"/projects/add\" class=\"btn btn-primary\"><i class=\"oi oi-plus\"></i> Add new</a>\r\n    </div>\r\n</div>\r\n\r\n");
#line 16 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
 if (projects == null)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<div>Loading...</div>\r\n");
#line 19 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
}
else
{

#line default
#line hidden
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-striped table-hover");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Project name</th>\r\n                <th>Client name</th>\r\n                <th>&nbsp;</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#line 31 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
             foreach (var project in projects.Items)
            {

#line default
#line hidden
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#line 34 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
                         project.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#line 35 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
                         project.ClientName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "class", "text-right");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "btn-group");
            __builder.AddAttribute(24, "role", "group");
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/projects/" + (
#line 38 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
                                                 project.Id

#line default
#line hidden
            ) + "/edit");
            __builder.AddAttribute(28, "class", "btn btn-light");
            __builder.AddMarkupContent(29, "<i class=\"oi oi-pencil\"></i> Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "href", "/projects/" + (
#line 39 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
                                                 project.Id

#line default
#line hidden
            ) + "/delete");
            __builder.AddAttribute(33, "class", "btn btn-light text-danger");
            __builder.AddMarkupContent(34, "<i class=\"oi oi-delete\"></i> Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#line 43 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
            }

#line default
#line hidden
            __builder.AddContent(39, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.AddContent(42, "    ");
            __Blazor.TimeTracker.Client.Pages.Projects.TypeInference.CreatePager_0(__builder, 43, 44, 
#line 47 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
                   projects

#line default
#line hidden
            , 45, 
#line 47 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
                                      LoadProjects

#line default
#line hidden
            );
            __builder.AddMarkupContent(46, "\r\n");
#line 48 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 50 "C:\Users\dejan.tamamovic\Desktop\ASP.NET Core\workshop\TimeTracker\TimeTracker.Client\Pages\Projects.razor"
       
    PagedList<ProjectModel> projects;

    protected override async Task OnInitializedAsync()
    {
        await LoadProjects();
    }

    private async Task LoadProjects(int page = 1)
    {
        const int pageSize = 5;
        var url = $"projects?page={page}&size={pageSize}";
        projects = await ApiService.GetAsync<PagedList<ProjectModel>>(url);

        // State change not triggered from for loop above
        base.StateHasChanged();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ApiService ApiService { get; set; }
    }
}
namespace __Blazor.TimeTracker.Client.Pages.Projects
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
