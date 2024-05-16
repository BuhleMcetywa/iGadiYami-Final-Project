using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class StartGardeningPage : ContentPage
{
	public StartGardeningPage(StartGardeningPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}