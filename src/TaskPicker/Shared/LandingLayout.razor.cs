using Microsoft.AspNetCore.Components;
using TaskPicker.Services;

namespace TaskPicker.Shared
{
    public partial class LandingLayout : LayoutComponentBase
    {
        [Inject] protected LayoutService LayoutService { get; set; }

        private bool _drawerOpen = false;

        protected override void OnInitialized()
        {
            LayoutService.SetBaseTheme(Theme.TaskPickerTheme());

            base.OnInitialized();
        }

        private void ToggleDrawer()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}
