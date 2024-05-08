using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class SignupPage : ContentPage
{
	public SignupPage(SignUpPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}