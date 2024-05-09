using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class SignupPage : ContentPage
{
	public SignupPage(SignUpPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	private void SignUp_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new LoginPage(new LoginPageViewModel()));
    }
}