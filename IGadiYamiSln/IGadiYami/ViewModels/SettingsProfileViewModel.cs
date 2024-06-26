﻿using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;

namespace IGadiYami.ViewModels
{
    public partial class SettingsProfileViewModel : BaseViewModel
    {
        private ImageSource _profilephoto;
        public ImageSource ProfilePhoto
        {
            get { return _profilephoto; }
            set { _profilephoto = value; OnPropertyChanged(); }
        }

        public UserSettingsProfile User { get; set; }
        public SettingsProfileViewModel()
        {
            User = new UserSettingsProfile
            {
                Name = "Buhle Mcetywa",
                Location = "Kuils River",
                Bio = "I love farming and gardens and plants and trees and leafs and crops with roots from seeds and stuff."
            };
        }

        [RelayCommand]
        private static async Task ProfileCommand()
        {
            // Logic to view the user's profile
            // Navigation
            await Shell.Current.GoToAsync("profilepage");
        }

        [RelayCommand]
        private async Task ChangeProfilePage()
        {
            FileResult photo = await MediaPicker.Default.PickPhotoAsync(new MediaPickerOptions
            {
                Title = "Choose New Photo"
            });

            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
                ProfilePhoto = ImageSource.FromStream(() => stream);
            }
        }

        [RelayCommand]
        private static async Task BackArrowCommand()
        {
            //Logic to go back to the settings page from the about us page
            //Navigation
            await Shell.Current.GoToAsync("\\settingspage");
        }

        [RelayCommand]
        private static async Task SaveButtonCommand()
        {
             // Logic to save information on the profile page
             await Application.Current.MainPage.DisplayAlert("Save", "The information that has been entered has been saved.", "OK");
        }

        [RelayCommand]
        private static async Task BackButtonCommand()
        {
            //Logic to go back to the settings page from the profile page
            //Navigation
              await Shell.Current.GoToAsync("\\settingspage");
        }

        /*[RelayCommand]
        private static void PremiumTabCommand()
        {
             Logic for premium tab
        }*/

        [RelayCommand]
        private static async Task AboutUsCommand()
        {
            // Logic to show about us
            // Navigation
            await Shell.Current.GoToAsync("aboutuspage");
        }

        [RelayCommand]
        private static async Task TermsAndConditionsCommand()
        {
            // Logic to show terms and conditions
            // Navigation
             await Shell.Current.GoToAsync("termsconditions");
        }
    }
}
