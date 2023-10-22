using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class Notification
    {
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsRead { get; set; }

        public Notification(string message)
        {
            Message = message;
            Timestamp = DateTime.Now;
            IsRead = false; // By default, a notification is unread.
        }

        // Method to mark the notification as read
        public void MarkAsRead()
        {
            IsRead = true;
        }
    }
}
