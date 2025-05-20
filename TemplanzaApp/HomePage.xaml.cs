namespace TemplanzaApp;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void GoToShop(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ShopPage");
    }

    private async void GoToDeveloper(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AboutDevPage");
    }

    private async void GoToService(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ServicePage");
    }

    private async void GoToLogin(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//LoginPage");
    }
}
