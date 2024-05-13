using IGadiYami.Configuration;
using IGadiYami.Services;
using IGadiYami.Views;
using IGadiYami.ViewModels;
using Microsoft.Extensions.Logging;
using Camera.MAUI;

namespace IGadiYami
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCameraView()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.RegisterServices()
               .RegisterViewModels()
               .RegisterViews();

            return builder.Build();
        }

        // Registering Views/Models/ViewModels
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<IPlantDatabase, PlantDatabase>();
            mauiAppBuilder.Services.AddTransient<ISettings, Settings>();
            mauiAppBuilder.Services.AddTransient<IProfileDatabase, ProfileDatabase>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            //mauiAppBuilder.Services.AddSingleton<TestViewModel>();
            mauiAppBuilder.Services.AddSingleton<CameraPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<LoginPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<SignUpPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<StartUpPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<ProfilePageViewModel>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            //mauiAppBuilder.Services.AddSingleton<TestPage>();
            mauiAppBuilder.Services.AddSingleton<LoginPage>();
            mauiAppBuilder.Services.AddSingleton<SignupPage>();
            mauiAppBuilder.Services.AddSingleton<StartPage>();
            mauiAppBuilder.Services.AddSingleton<CameraPage>();
            mauiAppBuilder.Services.AddSingleton<ProfilePage>();
            return mauiAppBuilder;
        }
    }
}
