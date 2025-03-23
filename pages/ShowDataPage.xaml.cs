using MauiApp2.viewmodel;

namespace MauiApp2.pages;

public partial class ShowDataPage : ContentPage
{
	public ShowDataPage()
	{
		InitializeComponent();
		BindingContext = new ShowDataViewModel();
	
	}
}