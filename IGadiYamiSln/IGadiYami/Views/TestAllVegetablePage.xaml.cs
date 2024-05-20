using IGadiYami.ViewModels.Test;

namespace IGadiYami.Views;

public partial class TestAllVegetablePage : ContentPage
{
	public TestAllVegetablePage(TestAllVegetablesViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        ((TestAllVegetablesViewModel)BindingContext).OnAppearing();
    }
}