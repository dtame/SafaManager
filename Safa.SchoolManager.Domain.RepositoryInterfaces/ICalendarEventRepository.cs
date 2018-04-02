using Safa.SchoolManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safa.SchoolManager.Domain.RepositoryInterfaces
{
    public interface ICalendarEventRepository
    {
        bool AddCalendarEvent(CalendarEvent evt);
        bool UpdateCalendarEvent(CalendarEvent evt);
        bool DeleteCalendarEvent(CalendarEvent evt);
        List<CalendarEvent> GetEventsByEmail(string email);
    }
}
