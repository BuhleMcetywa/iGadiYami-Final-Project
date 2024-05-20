using IGadiYami.Models.ChatbotFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
