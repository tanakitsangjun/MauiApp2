namespace MauiApp2.pages;
[QueryProperty(nameof(Username),"uname")]
[QueryProperty(nameof(Password),"password")]

[QueryProperty(nameof(loginobject),"data")]
public partial class forgerpasswordpage : ContentPage
{
	// string username = "";
	// string password = "";
	public string Username {get ; set;}
	public string Password {get ; set;}

	public LoginData loginobject { get; set; }
	public forgerpasswordpage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }

    private void Button_Clicked1(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.WriteLine($"username {Username}");
		System.Diagnostics.Debug.WriteLine(loginobject.Username);
    }
}