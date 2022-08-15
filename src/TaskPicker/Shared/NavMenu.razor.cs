using Microsoft.AspNetCore.Components;

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
