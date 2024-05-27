using CommunityToolkit.Mvvm.Input;
using IGadiYami.Services;

namespace IGadiYami.ViewModels
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        private UserDatabase _userDatabase;

        private string _useremaillogin;
        public string UserEmailLogin
        {
            get { return _useremaillogin; }
            set { _useremaillogin = value; OnPropertyChanged(); }
        }
        private string _userpasswordlogin;
        public string UserpasswordLogin
        {
            get { return _userpasswordlogin; }
            set { _userpasswordlogin = value; OnPropertyChanged(); }
        }

        public LoginPageViewModel()
        {
            _userDatabase = new UserDatabase();
        }

        [RelayCommand]
        public async void Login()
        {
            string email = UserEmailLogin;
            string password = UserpasswordLogin;

            if (_userDatabase.VerifyUserPassword(email, password))
            {
                // Navigation
                // await App.Current.MainPage.Navigation.PushAsync(new StartGardeningPage(new StartGardeningPageViewModel()));

                await Shell.Current.GoToAsync("startgardening");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "User not found, create a account", "Ok");
            }
        }
    }
}
