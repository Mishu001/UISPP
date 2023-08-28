namespace UISPP.Pages;

public partial class QandAPage : ContentPage
{
	public QandAPage()
	{
		InitializeComponent();
	}
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}