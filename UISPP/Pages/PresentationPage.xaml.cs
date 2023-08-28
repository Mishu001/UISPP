using System.Runtime.CompilerServices;
using UISPP.DataServices;
using UISPP.ViewModels;

namespace UISPP.Pages;

public partial class PresentationPage : ContentPage
{
    

	public PresentationPage(PresentationViewModel vm)
	{
		InitializeComponent();
        this.BindingContext= vm;
        
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