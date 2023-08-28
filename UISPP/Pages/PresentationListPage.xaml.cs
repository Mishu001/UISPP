using UISPP.ViewModels;

namespace UISPP.Pages;

public partial class PresentationListPage : ContentPage
{
	public PresentationListPage(PresentationListViewModel vm)
	{
		InitializeComponent();
        this.BindingContext= vm;
	}
    async void PresentationTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(PresentationPage));
    }
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}