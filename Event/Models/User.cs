using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string location { get; set; }


        public User(string firstName, string lastName, string password, string email, string phoneNumber, string location)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.location = location;
        }

       

        // Method to create a new event
        //public void CreateEvent(string name, DateTime date, DateTime time, string location, string description, bool isVisible)
        //{
        //    Event newEvent = new Event(name, date, time, location, description, isVisible);
        //    CreatedEvents.Add(newEvent);
        //}

        //// Method to join an event
        //public void
        //(Event eventToJoin)
        //{
        //    eventToJoin.AddAttendee(this);
        //    JoinedEvents.Add(eventToJoin);
        //}

        //// Method to leave an event
        //public void LeaveEvent(Event eventToLeave)
        //{
        //    eventToLeave.RemoveAttendee(this);
        //    JoinedEvents.Remove(eventToLeave);
        //}

        //// Method to send a notification
        //public void SendNotification(string message)
        //{
        //    Notification notification = new Notification(message);
        //    Notifications.Add(notification);
        //}
    }
}

