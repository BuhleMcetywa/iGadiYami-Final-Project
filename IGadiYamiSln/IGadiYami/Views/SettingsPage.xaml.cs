using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsProfileViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}