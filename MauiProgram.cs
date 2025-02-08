using AppStarPare.Models.Navigation;
using AppStarPare.Models.Usuario;
using AppStarPare.Services;
using AppStarPare.View;
using AppStarPare.ViewModel;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace AppStarPare
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // Registrar a interface IUsuario e sua implementação
            builder.Services.AddSingleton<IUsuario, Usuario>();
            builder.Services.AddSingleton<ICameraService, CameraService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>(); 

            // Registrar o ViewModel
            builder.Services.AddSingleton<LoginViewModel>();
            builder.Services.AddSingleton<CameraViewModel>();
            builder.Services.AddSingleton<EstacionarViewModel>();

            builder.Services.AddTransient<EstacionarViewModel>();
            builder.Services.AddTransient<Estacionar>();

            // Registrar a MainPage
            builder.Services.AddSingleton<Login>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
