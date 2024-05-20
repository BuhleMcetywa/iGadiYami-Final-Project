﻿using IGadiYami.Configuration;
using IGadiYami.Services;
using IGadiYami.Views;
using IGadiYami.ViewModels;
using Microsoft.Extensions.Logging;
using Camera.MAUI;
using IGadiYami.Interface;
using CommunityToolkit.Maui;
using IGadiYami.ViewModels.PlantPageViewModels;
using IGadiYami.Views.Plant_Views;
using IGadiYami.Views.PlantViews;


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
            mauiAppBuilder.Services.AddTransient<IPlantDatabase, PlantDatabase>();
            mauiAppBuilder.Services.AddTransient<ISettings, Settings>();
            mauiAppBuilder.Services.AddTransient<IService, Service>();
            mauiAppBuilder.Services.AddTransient<IAlertDialogService, DefaultMauiAlertDialogService>();
            mauiAppBuilder.Services.AddTransient<IUserDatabase, UserDatabase>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<CameraPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<LoginPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<SignUpPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<StartUpPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<TomatoViewModel>();
            mauiAppBuilder.Services.AddSingleton<StartGardeningPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<OnionPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<CarrotPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<SpinachPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<TomatoPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<PotatoPageViewModel>();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<LoginPage>();
            mauiAppBuilder.Services.AddSingleton<SignupPage>();
            mauiAppBuilder.Services.AddSingleton<StartPage>();
            mauiAppBuilder.Services.AddSingleton<CameraPage>();
            mauiAppBuilder.Services.AddSingleton<StartGardeningPage>();
            mauiAppBuilder.Services.AddSingleton<CarrotPage>();
            mauiAppBuilder.Services.AddSingleton<OnionPage>();
            mauiAppBuilder.Services.AddSingleton<TomatoPage>();
            mauiAppBuilder.Services.AddSingleton<SpinachPage>();
            mauiAppBuilder.Services.AddSingleton<PotatoPage>();
            return mauiAppBuilder;
        }
    }
}
