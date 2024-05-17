using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class SignupPage : ContentPage
{
	SignUpPageViewModel _viewModel;
	public SignupPage(SignUpPageViewModel vm)
	{
		_viewModel = vm;
		InitializeComponent();
		BindingContext = _viewModel;
	}
   

    void OnGoogleGestureRecognizerTapped(object sender, TappedEventArgs args)
    {
        // Handle the tap
    }
    void OnMicrosoftGestureRecognizerTapped(object sender, TappedEventArgs args)
    {
        // Handle the tap
    }
}