using System.Diagnostics;

namespace SampleApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new SecondPage());
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
		Debug.WriteLine("Back to MainPage!");
    }
}

