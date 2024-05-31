using IGadiYami.ViewModels;

namespace IGadiYami.Views
{
    public partial class StartPage : ContentPage
    {
        StartUpPageViewModel _viewModel;
        public StartPage(StartUpPageViewModel vm)
        {
            _viewModel = vm;
            InitializeComponent();
            BindingContext = _viewModel;
        }
    }
}