using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Location { get; set; }
        public List<Event> CreatedEvents { get; set; }
        public List<Event> JoinedEvents { get; set; }
        public List<Notification> Notifications { get; set; }

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
            CreatedEvents = new List<Event>();
            JoinedEvents = new List<Event>();
            Notifications = new List<Notification>();
        }

        // Method to create a new event
        public void CreateEvent(string name, DateTime date, DateTime time, string location, string description, bool isVisible)
        {
            Event newEvent = new Event(name, date, time, location, description, isVisible);
            CreatedEvents.Add(newEvent);
        }

        // Method to join an event
        public void JoinEvent(Event eventToJoin)
        {
            eventToJoin.AddAttendee(this);
            JoinedEvents.Add(eventToJoin);
        }

        // Method to leave an event
        public void LeaveEvent(Event eventToLeave)
        {
            eventToLeave.RemoveAttendee(this);
            JoinedEvents.Remove(eventToLeave);
        }

        // Method to send a notification
        public void SendNotification(string message)
        {
            Notification notification = new Notification(message);
            Notifications.Add(notification);
        }
    }
}

