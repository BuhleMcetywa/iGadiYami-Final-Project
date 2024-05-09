using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CameraPage : ContentPage
{
	public CameraPage(CameraPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}