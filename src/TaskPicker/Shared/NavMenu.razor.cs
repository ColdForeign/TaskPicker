using System.Linq;
using Microsoft.AspNetCore.Components;
using TaskPicker.Extensions;
using TaskPicker.Services;

namespace TaskPicker.Shared
{
    public partial class NavMenu
    {
        [Inject] NavigationManager NavMan { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
    }
}
