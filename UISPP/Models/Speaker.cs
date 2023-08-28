using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UISPP.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public string University { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

    }
}
