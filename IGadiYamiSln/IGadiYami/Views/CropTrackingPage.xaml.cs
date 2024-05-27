using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CropTrackingPage : ContentPage
{
	public CropTrackingPage(CropTrackingPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}