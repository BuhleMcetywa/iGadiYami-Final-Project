using IGadiYami.ViewModels.PlantPageViewModels;

namespace IGadiYami.Views.Plant_Views;

public partial class CarrotPage : ContentPage
{
	public CarrotPage(CarrotPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}