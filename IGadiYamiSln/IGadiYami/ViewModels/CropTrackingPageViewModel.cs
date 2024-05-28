using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using IGadiYami.Views;

namespace IGadiYami.ViewModels
{
    public partial class CropTrackingPageViewModel : BaseViewModel
    {
        public CropTrackingPageViewModel()
        {
        }

        [RelayCommand]
        public void ShowPopUp()
        {
            var popup = new CropTrackingPopUpPage();
            Shell.Current.CurrentPage.ShowPopup(popup);
        }
    }
}
