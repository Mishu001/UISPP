using UISPP.ViewModels;

namespace UISPP.Pages;

public partial class SpeakerListPage : ContentPage
{

    public SpeakerListPage(SpeakerListViewModel vm)
	{
		InitializeComponent();
        this.BindingContext= vm;
    }
    
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}