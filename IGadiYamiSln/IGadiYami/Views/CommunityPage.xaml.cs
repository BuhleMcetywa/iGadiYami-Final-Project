using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CommunityPage : ContentPage
{
	public CommunityPage(CommunityPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}