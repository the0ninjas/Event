using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    // Class to store what events a user has joined
    public class JoinedEvent
    { 
        public int eventId {  get; set; }
        public string userEmail { get; set; }

        public JoinedEvent(int eventId, string userEmail) 
        { 
            this.eventId = eventId;
            this.userEmail = userEmail;
        }
    }
}
