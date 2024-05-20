using IGadiYami.ViewModels.PlantPageViewModels;

namespace IGadiYami.Views.PlantViews;

public partial class OnionPage : ContentPage
{
	public OnionPage(OnionPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}