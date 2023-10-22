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
        public List<User> Attendees { get; set; }

        public Event(string name, DateTime date, DateTime time, string location, string description, bool isVisible)
        {
            Name = name;
            Date = date;
            Time = time;
            Location = location;
            Description = description;
            IsVisible = isVisible;
            Attendees = new List<User>();
        }

        // Method to add an attendee to the event
        public void AddAttendee(User user)
        {
            Attendees.Add(user);
        }

        // Method to remove an attendee from the event
        public void RemoveAttendee(User user)
        {
            Attendees.Remove(user);
        }


    }
}
