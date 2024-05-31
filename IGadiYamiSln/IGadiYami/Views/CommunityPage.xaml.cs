using IGadiYami.ViewModels;

namespace IGadiYami.Views;

public partial class CommunityPage : ContentPage
{
    public CommunityPage()
    {
        InitializeComponent();
        BindingContext = new CommunityPageViewModel();
    }
    /*public CommunityPage(CommunityPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }*/
}