using IGadiYami.ViewModels.ChatbotViewModels;

namespace IGadiYami.Views;

public partial class IgadiYamiAnswerPage : ContentPage
{
    IgadiYamiAnswerViewModel _viewModel;
    public IgadiYamiAnswerPage(IgadiYamiAnswerViewModel vm)
    {
        _viewModel = vm;
        InitializeComponent();
        BindingContext = _viewModel;
    }
}