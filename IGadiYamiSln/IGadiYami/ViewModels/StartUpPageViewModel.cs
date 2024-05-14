using System;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IGadiYami.ViewModels;
using System.Threading.Tasks;
using IGadiYami.Views;
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
        public static async void GetStarted()
        {
            App.Current.MainPage.Navigation.PushAsync(new SignupPage(new SignUpPageViewModel()));
        }
    }
  
}
