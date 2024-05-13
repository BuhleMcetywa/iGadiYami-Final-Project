using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class ProfilePage : ContentPage
{
	ProfilePageViewModel _viewModel;
	public ProfilePage(ProfilePageViewModel vm)
	{
		_viewModel = vm;
		InitializeComponent();
		BindingContext = _viewModel;
	}
}