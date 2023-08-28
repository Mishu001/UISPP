using UISPP.Pages;
namespace UISPP;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	async void GoToNotifications(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync(nameof(Notifications));
	}

	async void GoToSchedule(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(SchedulePage));
    }
	async void GoToSpeakers(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(SpeakerListPage));
    }
    async void GoToPresentation(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync(nameof(PresentationListPage));
    }
    async void GoToSocialMedia(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SocialMediaPage));
    }
    async void GoToMaps(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MapsPage));
    }
    async void GoToMyCongress(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MyCongressPage));
    }
    async void GoToSponsors(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(SponsorsPage));
    }
    async void GoToQandA(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(QandAPage));
    }
    async void GoToInfo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(InfoPage));
    }
    async void GoToAcount(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AcountPage));
    }
    async void GoToScan(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(QRScanPage));
    }
}

