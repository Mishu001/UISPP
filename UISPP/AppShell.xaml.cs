using UISPP.Pages;
namespace UISPP;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute(nameof(Notifications), typeof(Notifications));
        Routing.RegisterRoute(nameof(SessionPage), typeof(SessionPage));
        Routing.RegisterRoute(nameof(PresentationPage), typeof(PresentationPage));
        Routing.RegisterRoute(nameof(SpeakerPage), typeof(SpeakerPage));
        Routing.RegisterRoute(nameof(SchedulePage), typeof(SchedulePage));
        Routing.RegisterRoute(nameof(ScheduleSessionsPage), typeof(ScheduleSessionsPage));
        Routing.RegisterRoute(nameof(SpeakerListPage), typeof(SpeakerListPage));
        Routing.RegisterRoute(nameof(PresentationListPage), typeof(PresentationListPage));
        Routing.RegisterRoute(nameof(SocialMediaPage), typeof(SocialMediaPage));
        Routing.RegisterRoute(nameof(MapsPage), typeof(MapsPage));
        Routing.RegisterRoute(nameof(MyCongressPage), typeof(MyCongressPage));
        Routing.RegisterRoute(nameof(SponsorsPage), typeof(SponsorsPage));
        Routing.RegisterRoute(nameof(QandAPage), typeof(QandAPage));
        Routing.RegisterRoute(nameof(InfoPage), typeof(InfoPage));
        Routing.RegisterRoute(nameof(AcountPage), typeof(AcountPage));
        Routing.RegisterRoute(nameof(QRScanPage), typeof(QRScanPage));

    }
}
