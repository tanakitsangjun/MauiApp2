using MauiApp2.viewmodel;
using Microsoft.UI.Xaml.Controls;

namespace MauiApp2.pages;

public partial class loginpage : ContentPage
{
	public loginpage()
	{
		InitializeComponent();
		BindingContext = new LoginViewMode();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		// System.Diagnostics.Debug.WriteLine(username.Text);
		// System.Diagnostics.Debug.WriteLine(pwd.Text);

		// if (username.Text == "admin" && pwd.Text == "admin")
		// {
		// 	await Navigation.PushAsync(new Viewpage());
		// }
		// else
		// {
		// 	await DisplayAlert("Error", "Username", "Password");
		// }
	}

	private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
	{
		// System.Diagnostics.Debug.WriteLine("ok");
		// var logindata = new LoginData
		// {
		// 	Username = username.Text,
		// 	Password = pwd.Text
		// };

		// var queryparam = new Dictionary<String, dynamic>(){
		// 	{
		// 		"data" , logindata
		// 		// ชื่อ data ตรงกับฝั่งรับ
		// 	}
		// };

		// await Shell.Current.GoToAsync($"{nameof(forgerpasswordpage)}",queryparam);
	}

}




public class LoginData
{
	public string Username { get; set; }
	public string Password { get; set; }
}