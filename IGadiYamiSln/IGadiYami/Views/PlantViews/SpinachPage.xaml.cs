using IGadiYami.ViewModels.PlantPageViewModels;

namespace IGadiYami.Views.PlantViews;

public partial class SpinachPage : ContentPage
{
	public SpinachPage(SpinachPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}