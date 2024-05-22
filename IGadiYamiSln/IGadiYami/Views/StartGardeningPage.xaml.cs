using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class StartGardeningPage : ContentPage
{
    public StartGardeningPage()
    {
    }

    public StartGardeningPage(StartGardeningPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();

        ((StartGardeningPageViewModel)BindingContext).OnAppearing();
    }
}