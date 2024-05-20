using IGadiYami.ViewModels.PlantPageViewModels;

namespace IGadiYami.Views.PlantViews;

public partial class PotatoPage : ContentPage
{
	public PotatoPage(PotatoPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}