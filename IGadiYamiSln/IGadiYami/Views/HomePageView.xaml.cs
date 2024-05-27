using IGadiYami.ViewModels;

namespace IGadiYami.Views
{
    public partial class HomePageView : ContentPage
    {
        HomePageViewModel _viewModel;

        public HomePageView(HomePageViewModel vm)
        {
            InitializeComponent();
            _viewModel = vm;

            BindingContext = _viewModel;
        }
    }
}