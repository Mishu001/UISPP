using UISPP.ViewModels;

namespace UISPP.Pages;

public partial class SpeakerPage : ContentPage
{
	public SpeakerPage(SpeakerViewModel vm)
	{
		InitializeComponent();
        this.BindingContext= vm;
	}
    
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}