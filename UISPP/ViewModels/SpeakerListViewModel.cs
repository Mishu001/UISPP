using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UISPP.Models;
using UISPP.Pages;

namespace UISPP.ViewModels
{
    public partial class SpeakerListViewModel : ObservableObject
    {
        public event PropertyChangedEventHandler PropertyChanged;

       

        private ObservableCollection<Speaker> speakers;

        public ObservableCollection<Speaker> Speakers
        {
            get => speakers;
            set
            {
                speakers = value;
                OnPropertyChanged();
            }
        }

        public SpeakerListViewModel()
        {
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
            speakers = new ObservableCollection<Speaker>(speakers2);
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

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
