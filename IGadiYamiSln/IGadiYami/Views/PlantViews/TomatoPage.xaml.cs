using IGadiYami.ViewModels.PlantPageViewModels;

namespace IGadiYami.Views.PlantViews;

public partial class TomatoPage : ContentPage
{
	public TomatoPage(TomatoPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}