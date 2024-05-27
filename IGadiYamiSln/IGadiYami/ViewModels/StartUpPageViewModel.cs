using CommunityToolkit.Mvvm.Input;

namespace IGadiYami.ViewModels
{
    public partial class StartUpPageViewModel : BaseViewModel
    {

        [RelayCommand]
        public async void GetStarted()
        {
            await Shell.Current.GoToAsync("signuppage");
        }
        [RelayCommand]
        public async void Login()
        {
            await Shell.Current.GoToAsync("loginpage");
        }
    }

}
