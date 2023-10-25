using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class EventAdministrator
    {
        public int eventId { get; set; }
        public string adminId { get; set; }

        public EventAdministrator(int eventId, string adminId) 
        {
            this.eventId = eventId;
            this.adminId = adminId;
        }
    }
}
