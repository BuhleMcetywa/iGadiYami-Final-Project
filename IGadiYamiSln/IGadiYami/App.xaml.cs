﻿using IGadiYami.Views;

namespace IGadiYami
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            //MainPage = new NavigationPage(new StartPage(new ViewModels.StartUpPageViewModel());
            //MainPage = new NavigationPage(new ProfilePage());
        }
    }
}
