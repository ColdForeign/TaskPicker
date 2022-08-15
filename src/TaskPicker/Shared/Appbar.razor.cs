using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TaskPicker.Services;

namespace TaskPicker.Shared;

public partial class Appbar
{
    [Parameter] public EventCallback<MouseEventArgs> DrawerToggleCallback { get; set; }

    [Inject] private LayoutService LayoutService { get; set; }
}
