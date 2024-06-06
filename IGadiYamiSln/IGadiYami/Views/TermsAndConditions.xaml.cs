using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class TermsAndConditions : ContentPage
{
	public TermsAndConditions(SettingsProfileViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}