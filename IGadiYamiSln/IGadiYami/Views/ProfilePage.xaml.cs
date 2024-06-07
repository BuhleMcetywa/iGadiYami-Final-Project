using IGadiYami.ViewModels;
namespace IGadiYami.Views;

public partial class ProfilePage : ContentPage
{
    public ProfilePage(SettingsProfileViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}