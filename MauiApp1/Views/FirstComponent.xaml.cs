namespace MauiApp1;

public partial class FirstComponent : ContentPage
{
	public FirstComponent()
	{
		InitializeComponent();
	}

    private void GoToAnotherPage(object sender, EventArgs e)
    {
         Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}