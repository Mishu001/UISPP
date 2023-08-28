namespace UISPP.Pages;

public partial class MapsPage : ContentPage
{
	public MapsPage()
	{
		InitializeComponent();
	}
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}