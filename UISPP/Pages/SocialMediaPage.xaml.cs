namespace UISPP.Pages;

public partial class SocialMediaPage : ContentPage
{
	public SocialMediaPage()
	{
		InitializeComponent();
	}
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}