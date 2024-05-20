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
        }
    }
}
