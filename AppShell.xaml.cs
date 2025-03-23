using MauiApp2.pages;

namespace MauiApp2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("forgerpasswordpage",typeof(forgerpasswordpage));
		Routing.RegisterRoute("registerpage",typeof(registerpage));
		Routing.RegisterRoute("ShowDataPage",typeof(ShowDataPage));
		
	}
}
