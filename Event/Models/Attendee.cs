﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class Attendee
    {     
        public int eventId { get; set; }
        public string userId { get; set; }

        public Attendee(int eventId, string userId)
        {
            this.eventId = eventId;
            this.userId = userId;
        }
    }
}
