namespace MauiApp3;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnDial_Clicked(object sender, EventArgs e)
	{
		try
		{
			PhoneDialer.Open(PhoneNum.Text);

        }
		catch
		{
			await DisplayAlert("Invalid Input", "Please enter a valid phone number", "OK");
		}
	}
}

