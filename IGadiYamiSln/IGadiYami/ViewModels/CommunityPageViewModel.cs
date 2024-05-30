using CommunityToolkit.Mvvm.Input;

namespace IGadiYami.ViewModels
{
    public partial class CommunityPageViewModel : BaseViewModel
    {
        private bool _ismessagevisible;
        public bool IsMessageVisible
        {
            get { return _ismessagevisible; }
            set { _ismessagevisible = value; OnPropertyChanged(); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { _message = value; OnPropertyChanged(); }
        }
        private string _reply;
        public string Reply
        {
            get { return _reply; }
            set { _reply = value; OnPropertyChanged(); }
        }


        public CommunityPageViewModel()
        {
            IsMessageVisible = false;
        }

        public void CreateMessage()
        {
            Reply = Message;
        }
        public void MakeMessageVisible()
        {
            IsMessageVisible = true;
        }
        [RelayCommand]
        public void ShowMessage()
        {
            MakeMessageVisible();
            CreateMessage();
            Message = "";
        }
    }
}
