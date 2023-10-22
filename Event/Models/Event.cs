using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class Event
    {
        public string Name { get; set; }
        public int EventId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }


        public Event(string name, DateTime date, DateTime time, string location, string description, bool isVisible)
        {
            Name = name;
            Date = date;
            Time = time;
            Location = location;
            Description = description;
            IsVisible = isVisible;
        }

        // Method to add an attendee to the event



    }
}
