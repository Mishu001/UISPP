using UISPP.DataServices;
using UISPP.ViewModels;

namespace UISPP.Pages;

public partial class SessionPage : ContentPage
{
    
    public SessionPage(SessionPageViewModel vm)
	{
		InitializeComponent();
        this.BindingContext = vm;
    }
    
    async void PresentationTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PresentationPage));
    }
    async void SpeakerTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SpeakerPage));
    }
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}