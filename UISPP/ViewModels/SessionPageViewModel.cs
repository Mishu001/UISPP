using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UISPP.DataServices;
using UISPP.Models;
using UISPP.Pages;

namespace UISPP.ViewModels
{
    [QueryProperty("Session","Session")]
    public partial class SessionPageViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<Presentation> presentations;

        [ObservableProperty]
        ObservableCollection<Speaker> speakers;
        

        [ObservableProperty]
        Session session;



        public SessionPageViewModel()
        {
            Presentations= new ObservableCollection<Presentation>();
            Speakers= new ObservableCollection<Speaker>();

            GetPresentations();
            GetSpeakers();
        }

        public void GetSpeakers()
        {
            List<Speaker> speakers2 = new List<Speaker>
            {
                new Speaker {Id = 1, EventId= 1, Name = "test", University = "test", City = "test", Country= "test"},
                new Speaker {Id = 1, EventId= 1, Name = "test1", University = "test1", City = "test1", Country= "test1"},
                 new Speaker {Id = 1, EventId= 1, Name = "test2", University = "test2", City = "test2", Country= "test2"}

            };
            Speakers = new ObservableCollection<Speaker>(speakers2);
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

        [RelayCommand]
        async Task PresentationTapped(Presentation presentation)
        {
            await Shell.Current.GoToAsync($"{nameof(PresentationPage)}",
                new Dictionary<string, object>
                {
                    {"Presentation", presentation }
                });
        }

        [RelayCommand]
        async Task SpeakerTapped(Speaker speaker)
        {
            await Shell.Current.GoToAsync($"{nameof(SpeakerPage)}",
                new Dictionary<string, object>
                {
                    {"Speaker", speaker }
                });
        }
    }
}
