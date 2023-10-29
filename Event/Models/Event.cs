using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class Event
    {
        public int eventId { get; set; }
        public string title { get; set; }
        public DateTime time { get; set; }
        public string location { get; set; }
        public int registrations { get; set; }
        public int capacity { get; set; }
        public bool isVisible { get; set; }
        public string imageName { get; set; }


        public Event(string title, DateTime time, string location, int capacity, string imageName)
        {
            this.title = title;
            this.time = time;
            this.location = location;
            this.capacity = capacity;
            this.registrations = 0;
            this.isVisible = true;
            this.imageName = imageName;
           
        }
    }
}
