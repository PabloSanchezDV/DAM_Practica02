using System.Diagnostics;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace DAM_Practica02.Views;

public partial class LoginPage : ContentPage
{
	// Hardcoded User & Password to test Login logic
	private string hardcodedUser = "User";
	private string hardcodedPassword = "1234";

	private string user = "";
	private string password = "";

	public LoginPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Saves User entry on UserEntry Value Changed
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public void OnUserEntryChanged(object sender, EventArgs e)
	{
		user = UserEntry.Text;
	}

    /// <summary>
    /// Saves Password entry on PasswordEntry Value Changed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void OnPasswordEntryChanged(object sender, EventArgs e)
	{
		password = PasswordEntry.Text;
	}

	/// <summary>
	/// Upon pressing Login Button, checks if User & Password are equal to the hardcoded ones.
	/// Displays an error message when user and / or password are wrong.
	/// Loads MainPage on success.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public void OnLogin(object sender, EventArgs e)
	{
		if (user.Equals(hardcodedUser) && password.Equals(hardcodedPassword))
            Application.Current.MainPage = new AppShell();
        else 
			ErrorMessage.IsVisible = true;
	}

	/// <summary>
	/// Triggers and awaits for a request to authenticate via fingerprint.
	/// On failure, displays an alert.
	/// On success, loads MainPage.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	public async void ClickedFingerprint(object sender, EventArgs e)
	{
		var request = new AuthenticationRequestConfiguration("Autenticación", "Autenticar con huella");
		var result = await CrossFingerprint.Current.AuthenticateAsync(request);
		if (result.Authenticated)
		{
			//await DisplayAlert("Acceso", "Acceso concedido", "Cerrar"); 
			Application.Current.MainPage = new AppShell();
        }
		else
		{
            await DisplayAlert("Acceso", "Acceso denegado", "Cerrar");
        }
    }
}