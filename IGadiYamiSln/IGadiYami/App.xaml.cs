﻿using IGadiYami.Views;


namespace IGadiYami
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StartPage(new ViewModels.StartUpPageViewModel());
        }
    }
}
