using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;

namespace IGadiYami.ViewModels
{
    public partial class SettingsProfileViewModel : BaseViewModel
    {
        public UserSettingsProfile User { get; set; }
        public SettingsProfileViewModel()
        {
            User = new UserSettingsProfile
            {
                Name = "Ndosi Yogurt",
                Location = "Khayelitsha",
                Bio = "I love farming and gardens and plants and trees and leafs and crops with roots from seeds and stuff."
            };
        }

        [RelayCommand]
        private async Task EditProfileCommand()
        {
            // Logic to edit profile
            // Navigation
            await Shell.Current.GoToAsync("editprofilepage");
        }

        [RelayCommand]
        private void UpdateInformationCommand()
        {
            // Logic to update information for the profile
        }

        [RelayCommand]
        private async void BackButtonCommand()
        {
            // Logic to go back to the settings page
            // Navigation
            await Shell.Current.GoToAsync("settingspage");
        }

        //[RelayCommand]
        //private void DarkModeCommand()
        //{
        //    // Logic to toggle dark mode
        //}

        [RelayCommand]
        private void PremiumTabCommand()
        {
            // Logic for premium tab
        }

        //[RelayCommand]
        //private void FAQCommand()
        //{
        //    // Logic to show FAQ
        //}

        //[RelayCommand]
        //private void HelpCommand()
        //{
        //    // Logic to show help
        //}

        [RelayCommand]
        private async void AboutUsCommand()
        {
            // Logic to show about us
            // Navigation
            await Shell.Current.GoToAsync("aboutuspage");
        }

        [RelayCommand]
        private async void TermsAndConditionsCommand()
        {
            // Logic to show terms and conditions
            // Navigation
            //await Shell.Current.GoToAsync("editprofilepage");
        }
    }
}
