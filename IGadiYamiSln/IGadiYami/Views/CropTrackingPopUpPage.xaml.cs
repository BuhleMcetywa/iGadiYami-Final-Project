using CommunityToolkit.Maui.Views;
using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CropTrackingPopUpPage : Popup
{
    public CropTrackingPopUpPage()
    {
    }

    public CropTrackingPopUpPage(CropTackingPopUpViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}