namespace UISPP.Pages;

public partial class SponsorsPage : ContentPage
{
	public SponsorsPage()
	{
		InitializeComponent();
	}
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}