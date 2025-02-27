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
                    fonts.AddFont("Montserrat.ttf", "Montserrat");
                    fonts.AddFont("MontserratItalic.ttf", "Montserratitalic");
                });


            builder.Services.AddHttpClient();

            // Registrar a interface IUsuario e sua implementação
            builder.Services.AddSingleton<INavigationService, NavigationService>();
            builder.Services.AddSingleton<ICameraService, CameraService>();

            builder.Services.AddTransient<IUsuario, Usuario>();
         
            builder.Services.AddTransient<LoginViewModel>();
            builder.Services.AddTransient<CameraViewModel>();
            builder.Services.AddTransient<MenuViewModel>();

            builder.Services.AddTransient<EntradaDeVeiculosViewModel>();
            builder.Services.AddTransient<Menu>();
            builder.Services.AddTransient<EntradaDeVeiculos>();
            builder.Services.AddTransient<Login>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
