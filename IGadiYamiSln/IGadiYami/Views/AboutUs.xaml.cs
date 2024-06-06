using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class AboutUs : ContentPage
{
    public AboutUs(SettingsProfileViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}