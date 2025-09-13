using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.Logging;
using TestProject.Pages;
using TestProject.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace TestProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<MainMenuPage>();
            builder.Services.AddTransient<MainMenuViewModel>();

            builder.Services.AddSingleton<IMessenger, WeakReferenceMessenger>();


            return builder.Build();
        }
    }
}
