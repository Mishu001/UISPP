using Camera.MAUI;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UISPP.Models;
using UISPP.Pages;

namespace UISPP.ViewModels
{
    public partial class AcountViewModel : ObservableObject
    {
        [ObservableProperty]
        User user;

        [ObservableProperty]
        ObservableCollection<Presentation> presentations;

        [ObservableProperty]
        ImageSource codeSource;

        public AcountViewModel()
        {
            User = new User();
            Presentations = new ObservableCollection<Presentation>();
            GetUser();
            GenerateQr();
            GetPresentations();
        }

        public void GetPresentations()
        {
            List<Presentation> presentations2 = new List<Presentation>
            {
                new Presentation {Id = 1, EventId= 1, Title="test", Description = "test", Date = new DateOnly(2023,9,5), StartTime = new TimeOnly(14,00), EndTime = new TimeOnly(15,00), Speakers = new int[] {1,2,3} },
                new Presentation {Id = 2, EventId= 1, Title="test1", Description = "test1", Date = new DateOnly(2023,9,5), StartTime = new TimeOnly(14,00), EndTime = new TimeOnly(15,00), Speakers = new int[] {1,2,3} }


            };
            Presentations = new ObservableCollection<Presentation>(presentations2);
        }

        public void GetUser()
        {
            User newUser = new User { Id = 1, Name = "Mihai Mihai", Email = "mihai@email.com", Presentations = new int[] { 1, 2 }, Sessions = new int[] {1} };
            User = newUser;
        }

        [RelayCommand]
        async Task PresentationTapped(Presentation presentation)
        {
            await Shell.Current.GoToAsync($"{nameof(PresentationPage)}",
                new Dictionary<string, object>
                {
                    {"Presentation", presentation }
                });
        }

        public void GenerateQr()
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("[1,2]", QRCodeGenerator.ECCLevel.L);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            CodeSource = ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }
    }
}
