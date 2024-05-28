using CommunityToolkit.Maui.Views;
using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CropTrackingPopUpPage : Popup
{

    public CropTrackingPopUpPage(CropTrackingPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}