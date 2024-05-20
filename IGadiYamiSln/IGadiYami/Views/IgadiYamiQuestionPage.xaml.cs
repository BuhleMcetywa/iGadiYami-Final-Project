using IGadiYami.ViewModels.ChatbotViewModels;

namespace IGadiYami.Views;

public partial class IgadiYamiQuestionPage : ContentPage
{
    IgadiYamiQuestionViewModel _viewModel;
    public IgadiYamiQuestionPage(IgadiYamiQuestionViewModel vm)
    {
        InitializeComponent();

        _viewModel = vm;

        BindingContext = _viewModel;
    }
}