using UISPP.Pages;
namespace UISPP;

using Camera.MAUI;
using CommunityToolkit.Maui;
using UISPP.DataServices;
using UISPP.ViewModels;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCameraView()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<Notifications>();
        builder.Services.AddTransient<SessionPage>();
        builder.Services.AddTransient<PresentationPage>();
        builder.Services.AddTransient<SpeakerPage>();
        builder.Services.AddTransient<SchedulePage>();
        builder.Services.AddTransient<ScheduleSessionsPage>();
        builder.Services.AddTransient<SpeakerListPage>();
        builder.Services.AddTransient<PresentationListPage>();
        builder.Services.AddTransient<SocialMediaPage>();
        builder.Services.AddTransient<MapsPage>();
        builder.Services.AddTransient<MyCongressPage>();
        builder.Services.AddTransient<SponsorsPage>();
        builder.Services.AddTransient<QandAPage>();
        builder.Services.AddTransient<InfoPage>();
        builder.Services.AddTransient<AcountPage>();
        builder.Services.AddTransient<QRScanPage>();

        builder.Services.AddSingleton<IRestDataService, RestDataService>();
        builder.Services.AddTransient<SessionPageViewModel>();
        builder.Services.AddTransient<PresentationViewModel>();
        builder.Services.AddTransient<SpeakerViewModel>();
        builder.Services.AddTransient<AcountViewModel>(); 
        builder.Services.AddSingleton<SpeakerListViewModel>();
        builder.Services.AddSingleton<ScheduleSessionViewModel>();
        builder.Services.AddSingleton<PresentationListViewModel>();

        return builder.Build();
	}
}
