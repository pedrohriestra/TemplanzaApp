namespace TemplanzaApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("HomePage", typeof(HomePage));
            Routing.RegisterRoute("AboutDevPage", typeof(AboutDevPage));
            Routing.RegisterRoute("ServicePage", typeof(ServicePage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("ShopPage", typeof(ShopPage));

        }
    }
}
