namespace UISPP.Pages;

public partial class MyCongressPage : ContentPage
{
	public MyCongressPage()
	{
		InitializeComponent();
	}
    async void PresentationTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SessionPage));
    }
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}