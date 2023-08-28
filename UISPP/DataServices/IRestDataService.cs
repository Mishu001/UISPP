using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UISPP.Models;

namespace UISPP.DataServices
{
    public interface IRestDataService
    {
        Task<List<Presentation>> GetAllPresentations();
        Task GetPresentationById(int id);
        Task<List<Presentation>> GetPresentationsByEventId();

    }
}
