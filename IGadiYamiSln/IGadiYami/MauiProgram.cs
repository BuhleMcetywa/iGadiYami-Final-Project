﻿using Camera.MAUI;
using CommunityToolkit.Maui;
using IGadiYami.Configuration;
using IGadiYami.Interface;
using IGadiYami.Services;
using IGadiYami.ViewModels;
using IGadiYami.ViewModels.ChatbotViewModels;
using IGadiYami.Views;
using IgadiYamiDesign.Views;
using Microsoft.Extensions.Logging;


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
            // mauiAppBuilder.Services.AddTransient<IPlantDatabase, PlantDatabase>();
            mauiAppBuilder.Services.AddTransient<PlantDatabase>();
            mauiAppBuilder.Services.AddTransient<ISettings, Settings>();
            mauiAppBuilder.Services.AddTransient<IService, Service>();
            mauiAppBuilder.Services.AddTransient<IAlertDialogService, DefaultMauiAlertDialogService>();
            mauiAppBuilder.Services.AddTransient<UserDatabase>();
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
            mauiAppBuilder.Services.AddSingleton<VegetablePageViewModel>();
            mauiAppBuilder.Services.AddSingleton<CreateAccountViewModel>();
            mauiAppBuilder.Services.AddSingleton<HomePageViewModel>();
            mauiAppBuilder.Services.AddSingleton<CropTrackingPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<CropTackingPopUpViewModel>();
            mauiAppBuilder.Services.AddSingleton<SettingsProfileViewModel>();
            mauiAppBuilder.Services.AddSingleton<TrackedCropViewModel>();
            mauiAppBuilder.Services.AddSingleton<CommunityPageViewModel>();

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
            mauiAppBuilder.Services.AddSingleton<CreateAccountPage>();
            mauiAppBuilder.Services.AddSingleton<VegetablePage>();
            mauiAppBuilder.Services.AddSingleton<SettingsPage>();
            mauiAppBuilder.Services.AddSingleton<ProfilePage>();
            mauiAppBuilder.Services.AddSingleton<EditProfilePage>();
            mauiAppBuilder.Services.AddSingleton<AboutUs>();
            mauiAppBuilder.Services.AddSingleton<HomePageView>();
            mauiAppBuilder.Services.AddSingleton<CropTrackingPage>();
            mauiAppBuilder.Services.AddSingleton<CropTrackingPopUpPage>();
            mauiAppBuilder.Services.AddSingleton<TrackedCrop>();
            mauiAppBuilder.Services.AddSingleton<CommunityPage>();
            //mauiAppBuilder.Services.AddSingleton<MainTabbedPage>();

            return mauiAppBuilder;
        }
    }
}
