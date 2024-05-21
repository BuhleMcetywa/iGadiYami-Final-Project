using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CreateAccountPage : ContentPage
{
	public CreateAccountPage(SignUpPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}