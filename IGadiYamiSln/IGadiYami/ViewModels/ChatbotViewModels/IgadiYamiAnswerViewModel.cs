using IGadiYami.Models.ChatbotFolder;

namespace IGadiYami.ViewModels.ChatbotViewModels
{
    [QueryProperty(nameof(Response), "Response")]
    public class IgadiYamiAnswerViewModel : BaseViewModel
    {
        private ChatMessage _questionResponseModel;

        public ChatMessage Response
        {
            get { return _questionResponseModel; }
            set
            {
                _questionResponseModel = value;

                OnPropertyChanged();
            }
        }

        public IgadiYamiAnswerViewModel()
        {
        }

    }
}
