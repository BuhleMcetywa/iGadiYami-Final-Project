using IGadiYami.Configuration;
using IGadiYami.Services;
using IGadiYami.Views;
using IGadiYami.ViewModels;
using Microsoft.Extensions.Logging;
using Camera.MAUI;
using IGadiYami.Interface;
using CommunityToolkit.Maui;
using IGadiYami.ViewModels.PlantPageViewModels;
using IGadiYami.ViewModels.ChatbotViewModels;
using IGadiYami.ViewModels.Test;

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
                .UseMauiCommunityToolkit()
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
            mauiAppBuilder.Services.AddTransient<IAiAssistant, IgadiYamiAiAssistant>();
            mauiAppBuilder.Services.AddTransient<IPlantDatabase, PlantDatabase>();
            mauiAppBuilder.Services.AddTransient<PlantDatabase>();
            mauiAppBuilder.Services.AddTransient<ISettings, Settings>();
            mauiAppBuilder.Services.AddTransient<IService, Service>();
            mauiAppBuilder.Services.AddTransient<IAlertDialogService, DefaultMauiAlertDialogService>();
            mauiAppBuilder.Services.AddTransient<IUserDatabase, UserDatabase>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<IgadiYamiQuestionViewModel>();
            mauiAppBuilder.Services.AddSingleton<IgadiYamiAnswerViewModel>();
            mauiAppBuilder.Services.AddSingleton<CameraPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<LoginPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<SignUpPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<StartUpPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<TomatoViewModel>();
            mauiAppBuilder.Services.AddSingleton<StartGardeningPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<TestAllVegetablesViewModel>();
            mauiAppBuilder.Services.AddSingleton<TestVegetablesViewModel>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<IgadiYamiQuestionPage>();
            mauiAppBuilder.Services.AddSingleton<IgadiYamiAnswerPage>();
            mauiAppBuilder.Services.AddSingleton<LoginPage>();
            mauiAppBuilder.Services.AddSingleton<SignupPage>();
            mauiAppBuilder.Services.AddSingleton<StartPage>();
            mauiAppBuilder.Services.AddSingleton<CameraPage>();
            mauiAppBuilder.Services.AddSingleton<StartGardeningPage>();
            mauiAppBuilder.Services.AddSingleton<TestAllVegetablePage>();
            mauiAppBuilder.Services.AddSingleton<TestVegetablePage>();
            return mauiAppBuilder;
        }
    }
}
