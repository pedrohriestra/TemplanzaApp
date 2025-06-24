namespace TemplanzaApp;

public partial class LoginPage : ContentPage
{
    bool isPasswordHidden = true;

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var username = usernameEntry.Text?.Trim();
        var password = passwordEntry.Text?.Trim();

        if (username == "admin" && password == "1234")
        {
            await Shell.Current.GoToAsync("HomePage");  
        }
        else
        {
            await DisplayAlert("Login Failed", "Invalid username or password", "OK");
        }

    }
    private void TogglePasswordVisibility(object sender, EventArgs e)
    {
        isPasswordHidden = !isPasswordHidden;
        passwordEntry.IsPassword = isPasswordHidden;
    }


}
