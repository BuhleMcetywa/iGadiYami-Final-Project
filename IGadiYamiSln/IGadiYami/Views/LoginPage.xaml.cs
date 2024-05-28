using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class LoginPage : ContentPage
{
    LoginPageViewModel _viewModel;
    public LoginPage(LoginPageViewModel vm)
    {
        _viewModel = vm;
        InitializeComponent();
        BindingContext = _viewModel;
    }
    protected async override void OnAppearing()
    {
        base.OnAppearing();
    }
}