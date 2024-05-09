using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class StartPage : ContentPage
{
	public StartPage(StartUpPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
	private void GetStarted_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new SignupPage(new SignUpPageViewModel()));
    }
}