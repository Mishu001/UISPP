using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    public partial class PresentationListViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Presentation> presentations;

        public PresentationListViewModel()
        {
            Presentations = new ObservableCollection<Presentation>();
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

        [RelayCommand]
        async Task PresentationTapped(Presentation presentation)
        {
            await Shell.Current.GoToAsync($"{nameof(PresentationPage)}",
                new Dictionary<string, object>
                {
                    {"Presentation", presentation }
                });
        }
    }
}
