using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class VegetablePage : ContentPage
{
    public VegetablePage()
    {
    }

    public VegetablePage(VegetablePageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        ((VegetablePageViewModel)BindingContext).OnAppearing();
    }
}