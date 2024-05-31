using IGadiYami.Views;

namespace IGadiYami
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        private void RegisterRoutes()
        {
            Routing.RegisterRoute("igadiyamiquestion", typeof(IgadiYamiQuestionPage));
            Routing.RegisterRoute("igadiyamianswer", typeof(IgadiYamiAnswerPage));
            //Routing.RegisterRoute("allvegetable", typeof(TestAllVegetablePage));
            Routing.RegisterRoute("vegetable", typeof(VegetablePage));
            Routing.RegisterRoute("startgardening", typeof(StartGardeningPage));
            Routing.RegisterRoute("signuppage", typeof(SignupPage));
            Routing.RegisterRoute("loginpage", typeof(LoginPage));
            Routing.RegisterRoute("createaccount", typeof(CreateAccountPage));
            Routing.RegisterRoute("aicamera", typeof(CameraPage));
            Routing.RegisterRoute("homepage", typeof(HomePageView));
            Routing.RegisterRoute("croptracking", typeof(CropTrackingPage));
            Routing.RegisterRoute("trackedcrop", typeof(TrackedCrop));
            Routing.RegisterRoute("communitypage", typeof(CommunityPage));
            Routing.RegisterRoute("settingspage", typeof(SettingsPage));
            Routing.RegisterRoute("profilepage", typeof(ProfilePage));
            //Routing.RegisterRoute("editingprofilepage", typeof(EditProfilePage));
            Routing.RegisterRoute("aboutuspage", typeof(AboutUs));
            //Routing.RegisterRoute("maintabbedpage", typeof(MainTabbedPage));
        }
    }
}
