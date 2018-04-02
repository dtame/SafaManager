using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.Entities
{
    public class CalendarEvent
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateThe { get; set; }
        public string CreateBy { get; set; } //email
        public string To { get; set; } //email 
        public bool IsAccepted { get; set; }
        public bool IsDenied { get; set; }
        public bool IsDone { get; set; }
        public bool IsMissed { get; set; }
    }
}
