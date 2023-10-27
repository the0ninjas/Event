using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Repository
{
    public class JoinedEventsRepo
    {
        private List<JoinedEvent> JoinedEvents = new List<JoinedEvent>();

        public bool joinEvent(int eventId, string userEmail, ConnectionFactory context)
        {
            try
            {
                JoinedEvent joinedEvent = new JoinedEvent(eventId, userEmail);
                context.JoinedEvents.Add(joinedEvent);
                context.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public (bool eventOfUser, bool ErrorOccurred) EventofUser(int eventId, string userEmail, ConnectionFactory context)
        {
            try
            {
                var joinedEvent = context.JoinedEvents
                    .Where(ea => ea.eventId == eventId && ea.userEmail == userEmail)
                    .ToList();

                return (eventOfUser: joinedEvent.Any(), ErrorOccurred: false);          
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return (eventOfUser: false, ErrorOccurred: true);
            }
        }

        public List<Event> GetEventsOfUser(string email, ConnectionFactory context)
        {
            try
            {

                // Find User Events for the given email
                var joinedEvents = context.JoinedEvents
                    .Where(ea => ea.userEmail == email)
                    .ToList();

                // Get the list of eventIds associated with the user
                List<int> eventIds = joinedEvents.Select(ea => ea.eventId).ToList();

                // Retrieve events with the specified eventIds
                var eventsOfUser = context.Events
                    .Where(e => eventIds.Contains(e.eventId))
                    .ToList();

                return eventsOfUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }


        public bool leaveEvent(int eventId)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    var eventToLeave = context.JoinedEvents
                        .FirstOrDefault(ea => ea.eventId == eventId);

                    if (eventToLeave != null)
                    {
                        context.JoinedEvents.Remove(eventToLeave);
                        context.SaveChanges();

                        return true;
                    }
                    else
                    {
                        // No UserEvent found with the specified eventId
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}
