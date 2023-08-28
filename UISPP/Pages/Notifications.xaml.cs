namespace UISPP.Pages;

public partial class Notifications : ContentPage
{
	public Notifications()
	{
		InitializeComponent();
	}
    async void OnTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SessionPage));
    }
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}