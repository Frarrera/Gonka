using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gonka.Client.Pages
{
    public partial class Index
    {
        [Inject]
        IJSRuntime Js { get; set; }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await Js.InvokeVoidAsync("Init");
            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
