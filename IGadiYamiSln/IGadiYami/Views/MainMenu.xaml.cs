using IGadiYami.ViewModels;
using Microsoft.Maui.Controls;

namespace IGadiYami.Views
{
    public partial class MainMenu : ContentPage
    {
        MainMenuViewModel _viewModel;

        public MainMenu() : this(new MainMenuViewModel())
        {
        }

        public MainMenu(MainMenuViewModel vm)
        {
            _viewModel = vm;
            InitializeComponent();
            BindingContext = _viewModel;
        }
    }
}
