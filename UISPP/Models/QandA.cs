using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UISPP.Models
{
    public class QandA
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

    }
}
