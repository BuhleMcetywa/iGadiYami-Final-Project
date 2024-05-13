using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class SignupPage : ContentPage
{
	SignUpPageViewModel _viewModel;
	public SignupPage(SignUpPageViewModel vm)
	{
		_viewModel = vm;
		InitializeComponent();
		BindingContext = _viewModel;
	}
}