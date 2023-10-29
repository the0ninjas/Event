using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class CreatedEvent
    {
        // class to store which events a user has created
        public int eventId { get; set; }
        public string userEmail { get; set; }

        public CreatedEvent(int eventId, string userEmail) 
        {
            this.eventId = eventId;
            this.userEmail = userEmail;
        }
    }
}
