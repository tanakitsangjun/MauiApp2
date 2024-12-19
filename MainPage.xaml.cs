namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		// count++;

		// if (count == 1)
		// 	CounterBtn.Text = $"Clicked {count} time";
		// else
		// 	CounterBtn.Text = $"Clicked {count} times";

		// SemanticScreenReader.Announce(CounterBtn.Text);
		// Console.WriteLine("hello world");
		System.Diagnostics.Debug.WriteLine("hello world5555555");
		// System.Diagnostics.Debug.Assert(false);
		// System.Diagnostics.Debug.WriteLine("hello world");
	}
}

