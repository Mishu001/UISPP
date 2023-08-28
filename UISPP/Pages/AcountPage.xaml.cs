using QRCoder;
using UISPP.ViewModels;

namespace UISPP.Pages;

public partial class AcountPage : ContentPage
{
    public AcountPage( AcountViewModel vm)
    {
        InitializeComponent();
        this.BindingContext= vm;
    }
    
    async void ToMainPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///MainPage");
    }

}