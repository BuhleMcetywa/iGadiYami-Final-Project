using IGadiYami.ViewModels;

namespace IGadiYami.Views
{
    public partial class HomePageView : ContentPage
    {
        public HomePageView(HomePageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}