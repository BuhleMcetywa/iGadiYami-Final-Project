using CommunityToolkit.Mvvm.Input;
using IGadiYami.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGadiYami.ViewModels
{
    public partial class SignUpPageViewModel : BaseViewModel
    {
        [RelayCommand]
        public void HaveAccount()
        {
            App.Current.MainPage.Navigation.PushAsync(new LoginPage(new LoginPageViewModel()));
        }
    }
}
