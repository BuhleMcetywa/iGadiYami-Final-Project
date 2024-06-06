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
        private static async Task BackArrowCommand()
        {
            //Logic to go back to the settings page from the about us page
            //Navigation
            await Shell.Current.GoToAsync("\\settingspage");
        }

        /*[RelayCommand]
        private static async Task EditButtonCommand()
        {
            Logic to edit information on the profile page
            await Shell.Current.GoToAsync("editingprofilepage");
        }*/

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
