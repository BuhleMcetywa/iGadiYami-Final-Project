using CommunityToolkit.Mvvm.Input;

namespace IGadiYami.ViewModels
{
    public partial class StartUpPageViewModel : BaseViewModel
    {
        //private void GetStarted_Clicked(object sender, EventArgs e)
        //{
        //App.Current.MainPage.Navigation.PushAsync(new SignupPage(new SignUpPageViewModel()));
        //}

        [RelayCommand]
        public async void GetStarted()
        {
            //await App.Current.MainPage.Navigation.PushAsync(new SignupPage(new SignUpPageViewModel()));
            await Shell.Current.GoToAsync("signuppage");
        }
        [RelayCommand]
        public async void Login()
        {
            //await App.Current.MainPage.Navigation.PushAsync(new SignupPage(new SignUpPageViewModel()));
            await Shell.Current.GoToAsync("loginpage");
        }
    }

}
