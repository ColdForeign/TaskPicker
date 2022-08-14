using Blazored.LocalStorage;
using Microsoft.Extensions.DependencyInjection;
using TaskPicker.Services;
using TaskPicker.Services.UserPreferences;
using MudBlazor.Services;
using MudBlazor;

namespace TaskPicker.Extensions
{
    public static class TaskPickerViewExtension
    {
        public static void TryAddViewServices(this IServiceCollection services)
        {
            services.AddMudServices(config =>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;
                config.SnackbarConfiguration.PreventDuplicates = false;
                config.SnackbarConfiguration.NewestOnTop = false;
                config.SnackbarConfiguration.ShowCloseIcon = true;
                config.SnackbarConfiguration.VisibleStateDuration = 10000;
                config.SnackbarConfiguration.HideTransitionDuration = 500;
                config.SnackbarConfiguration.ShowTransitionDuration = 500;
                config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
            });

            services.AddBlazoredLocalStorage();
            services.AddScoped<IUserPreferencesService, UserPreferencesService>();
            services.AddScoped<LayoutService>();
        }
    }
}
