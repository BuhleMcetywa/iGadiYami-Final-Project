using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class VegetablePage : ContentPage
{
	public VegetablePage(VegetablePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}