namespace UISPP.Pages;

public partial class SchedulePage : ContentPage
{
	public SchedulePage()
	{
		InitializeComponent();
	}
    async void OnTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ScheduleSessionsPage));
    }
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}