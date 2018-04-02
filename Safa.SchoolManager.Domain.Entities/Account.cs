using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.Entities
{
    public class Account
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; } 
        public string Code { get; set; }
        public string InvoiceNumber { get; set; }
        public int ProgramID { get; set; }
        public int InstructorID { get; set; }
        public List<CalendarEvent> EventList { get; set; }
    }

    
}
