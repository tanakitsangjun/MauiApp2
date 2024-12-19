namespace MauiApp2.pages;

public partial class loginpage : ContentPage
{
	public loginpage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debug.WriteLine(username.Text);
		System.Diagnostics.Debug.WriteLine(pwd.Text);

		if(username.Text == "admin" && pwd.Text == "admin"){
		 	await Navigation.PushAsync(new Viewpage());
		}else{
		  	await	DisplayAlert("Error","Username", "Password");
		}
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		System.Diagnostics.Debug.WriteLine("ok");
		await Shell.Current.GoToAsync(nameof(forgerpasswordpage));
    }

}