namespace MauiApp2.pages;

public partial class forgerpasswordpage : ContentPage
{
	public forgerpasswordpage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..");
    }
}