using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CameraPage : ContentPage
{
	CameraPageViewModel _viewModel;
	public CameraPage(CameraPageViewModel vm)
	{
        _viewModel = vm;
        InitializeComponent();
		BindingContext = _viewModel;
	}
}