using IGadiYami.Views;

namespace IGadiYami
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        private void RegisterRoutes()
        {
            Routing.RegisterRoute("allvegetable", typeof(TestAllVegetablePage));
            Routing.RegisterRoute("vegetable", typeof(TestVegetablePage));
        }
    }
}
