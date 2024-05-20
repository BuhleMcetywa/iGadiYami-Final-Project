using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CreateAccountPage : ContentPage
{
	public CreateAccountPage(CreateAccountViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}