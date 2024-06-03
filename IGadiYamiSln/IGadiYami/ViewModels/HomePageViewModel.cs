using CommunityToolkit.Mvvm.Input;
using IGadiYami.Models;
using IGadiYami.Services;

namespace IGadiYami.ViewModels
{
    public partial class HomePageViewModel : BaseViewModel
    {
        SignUpPageViewModel _signUpPageViewModel;
        private UserDatabase _userdatabase;
        public IList<MenuOptions> Menu { get; private set; }

        private string _displayname;
        public string DisplayName
        {
            get { return _displayname; }
            set { _displayname = value; OnPropertyChanged(); }
        }
        private string _displaycurrenttime;

        public string DisplayCurrentTime
        {
            get { return _displaycurrenttime; }
            set { _displaycurrenttime = value; OnPropertyChanged(); }
        }



        public HomePageViewModel(UserDatabase userDatabase)
        {
            _userdatabase = userDatabase;
            CreateMenuCollection();
            //GetUserNameToDisplay();
            GetCurrenTime();
        }
        public void GetCurrenTime()
        {
            //var signupentry = _signUpPageViewModel.Name;
            //var name = _userdatabase.GetUserByName("Ethan");
            //DisplayName = name.UserName; 

            var currentTime = DateTime.Now;
            var timeString = currentTime.ToString("HH:mm:ss tt");

            int hour = currentTime.Hour;

            if (hour < 12)
            {
                DisplayCurrentTime = $"Good Morning! {DisplayName}";
            }
            else if (hour < 18)
            {
                DisplayCurrentTime = $"Good Afternoon! {DisplayName}";
            }
            else
            {
                DisplayCurrentTime = $"Good Evening! {DisplayName}";
            }
        }

        [RelayCommand]
        private async static Task OnGoToStartGardeningPageAsync()
        {
            await Shell.Current.GoToAsync("startgardening");
        }
        [RelayCommand]
        private async static Task OnGoToAiCameraPageAsync()
        {
            await Shell.Current.GoToAsync("aicamera");
        }
        [RelayCommand]
        private async static Task OnGoToCommunityPageAsync()
        {
            await Shell.Current.GoToAsync("communitypage");
        }
        [RelayCommand]
        private async static Task OnGoToPremiumFeaturePageAsync()
        {
            await Shell.Current.GoToAsync("croptracking");
        }


        void CreateMenuCollection() // Changed return type to void
        {
            Menu = new List<MenuOptions>();

            Menu.Add(new MenuOptions
            {
                OptionName = "Start Gardening",
                Description = "Embark on your gardening journey with us. Our reliable database helps you choose plants and tackle issues. Experience the joy of gardening with us holding your hand all the way",
                ImageUrl = "pic3.png"
            });

            Menu.Add(new MenuOptions
            {
                OptionName = "Join Our Community",
                Description = "Meet our passionate members, share ideas, learn new things, and become an integral part of our growing network. We believe in the power of unity and collaboration.",
                ImageUrl = "pic1.png"
            });

            Menu.Add(new MenuOptions
            {
                OptionName = "Ai Vision diagnosis",
                Description = "Our AI-powered tools can help identify potential issues, suggest remedies, and optimize crop health for better yield. Embrace the future of farming with us.",
                ImageUrl = "pic2.png"
            });
        }
    }
}