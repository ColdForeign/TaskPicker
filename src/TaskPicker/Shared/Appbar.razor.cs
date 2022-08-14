using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using TaskPicker.Extensions;
using TaskPicker.Services;

namespace TaskPicker.Shared;

public partial class Appbar
{
    [Parameter] public EventCallback<MouseEventArgs> DrawerToggleCallback { get; set; }

    [Inject] private LayoutService LayoutService { get; set; }
}
