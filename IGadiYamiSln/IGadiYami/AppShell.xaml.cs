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
            Routing.RegisterRoute("mainmenu", typeof(MainMenu));
            Routing.RegisterRoute("camerapage", typeof(CameraPage));
        }
    }
}
