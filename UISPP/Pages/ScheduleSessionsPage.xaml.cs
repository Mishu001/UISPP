using UISPP.ViewModels;

namespace UISPP.Pages;

public partial class ScheduleSessionsPage : ContentPage
{
	public ScheduleSessionsPage(ScheduleSessionViewModel vm)
	{
		InitializeComponent();
        this.BindingContext= vm;
	}
    
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}