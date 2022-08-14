using Microsoft.AspNetCore.Components;
using TaskPicker.Services;

namespace TaskPicker.Shared;

public partial class AppbarButtons
{
    [Inject] private LayoutService LayoutService { get; set; }
}
