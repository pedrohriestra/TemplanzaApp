namespace TemplanzaApp;

public partial class ShopPage : ContentPage
{
	public ShopPage()
	{
		InitializeComponent();
	}
    private async void OnBuyClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Purchase", "Simulated purchase successful!", "OK");
    }
}