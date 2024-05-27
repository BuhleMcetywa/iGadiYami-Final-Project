using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CropTrackingFeaturePage : ContentPage
{
	public CropTrackingFeaturePage(CropTrackingFeaturePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}