// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RecipeManager.Pages.Recipe
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using RecipeManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using RecipeManager.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\Pages\Recipe\RecipesList.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\Pages\Recipe\RecipesList.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/recipes")]
    public partial class RecipesList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\Projects\Code with Julian\2021\39. RecipeManager-7\Project\tutorial\RecipeManager-2\RecipeManager\Pages\Recipe\RecipesList.razor"
       
    List<Recipe> Recipes = new List<Recipe>();

    protected override async Task OnInitializedAsync()
    {
        Recipes = RecipeService.List();
    }

    private void RedirectTo(int recipeId)
    {
        NavigationManager.NavigateTo($"/recipe/details/{recipeId}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRecipeService RecipeService { get; set; }
    }
}
#pragma warning restore 1591
