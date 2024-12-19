namespace MauiApp2.pages;

public partial class Viewpage : ContentPage
{
  public Viewpage()
  {
    InitializeComponent();
  }

  private async void Button_Clicked(object sender, EventArgs e)
  {
    // System.Diagnostics.Debug.WriteLine("hello world");
    // DisplayAlert("Alert", "สวัสดี", "ยกเลิก");

    await Navigation.PopAsync();
  }

  private void ImageButton_Clicked(object sender, EventArgs e)
  {
  }

}