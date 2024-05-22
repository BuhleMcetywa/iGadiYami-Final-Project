using IGadiYami.Models;
using CommunityToolkit.Mvvm.Input;

namespace IGadiYami.ViewModels
{
    public partial class SettingsProfileViewModel : BaseViewModel
    {
        public UserSettingsProfile User {  get; set; }
        public SettingsProfileViewModel() 
        {
            User = new UserSettingsProfile
            {
                Name = "Ndosi Yogurt",
                Location = "Khayelitsha"
            };
        }

        [RelayCommand]
        private void EditProfileCommand()
        {
            // Logic to edit profile
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
        private void AboutUsCommand()
        {
            // Logic to show about us
        }

        [RelayCommand]
        private void TermsAndConditionsCommand()
        {
            // Logic to show terms and conditions
        }
    }
}
