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
    public partial class ScheduleSessionViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Session> sessions;

        

        public ScheduleSessionViewModel()
        {
            Sessions = new ObservableCollection<Session>();
            GetSessions();
        }

        

        
        public void GetSessions()
        {
            List<Session> sessions2 = new List<Session>
            {
                new Session{Id = 1, EventId= 1, Title="test", Room = "Room 1", Date = new DateOnly(2023,9,5), StartTime = new TimeOnly(14,10), EndTime = new TimeOnly(15,00), Presentations = new int[] {2}, Speakers = new int[] {1,2} },
                new Session{Id = 1, EventId= 1, Title="test", Room = "Room 1", Date = new DateOnly(2023,9,5), StartTime = new TimeOnly(14,00), EndTime = new TimeOnly(15,00), Presentations = new int[] {1}, Speakers = new int[] {2,3} }

            };
            Sessions = new ObservableCollection<Session>(sessions2);
        }

        [RelayCommand]
        async Task SessionTapped(Session session)
        {
            await Shell.Current.GoToAsync($"{nameof(SessionPage)}", 
                new Dictionary<string, object>
                {
                    {"Session", session }
                });
        }
    }
}
