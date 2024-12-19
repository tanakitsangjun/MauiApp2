using MauiApp2.pages;

namespace MauiApp2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("forgetpassword",typeof(forgerpasswordpage));
	}
}
