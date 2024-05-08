using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class StartPage : ContentPage
{
	public StartPage(StartUpPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}