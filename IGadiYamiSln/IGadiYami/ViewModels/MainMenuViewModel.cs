﻿using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;
using IGadiYami.Views;
//using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Windows.Input;

namespace IGadiYami.ViewModels
{
    public partial class MainMenuViewModel : BaseViewModel
    {
        public IList<MenuOptions> Menu { get; private set; }

        public MainMenuViewModel()
        {
            CreateMenuCollection();
        }

        [RelayCommand]
        public static async Task Navigate(MainMenu mainMenu)
        {
            var navigationParameter = new Dictionary<string, object>
           {
                { "StartGardening", mainMenu }
           };
            await Shell.Current.GoToAsync($"startgardening", navigationParameter);


        }

        void CreateMenuCollection()
        {
            Menu = new List<MenuOptions>();

            Menu.Add(new MenuOptions
            {
                OptionName = "Start Gardening",
                Description = "Embark on your gardening journey with us. Our reliable database helps you choose plants and tackle issues. Experience the joy of gardening with us holding your hand all the way",
                ImageUrl = "pic3.png"
            });

            Menu.Add(new MenuOptions
            {
                OptionName = "Join Our Community",
                Description = "Meet our passionate members, share ideas, learn new things, and become an integral part of our growing network. We believe in the power of unity and collaboration.",
                ImageUrl = "pic1.png"
            });

            Menu.Add(new MenuOptions
            {
                OptionName = "Ai Vision diagnosis",
                Description = "Our AI-powered tools can help identify potential issues, suggest remedies, and optimize crop health for better yield. Embrace the future of farming with us.",
                ImageUrl = "pic2.png"
            });
        }
    }
}
