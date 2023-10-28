using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
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
                EventRepo eventRepo = new EventRepo();
                eventRepo.eventRegistration(eventId, context);
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

                // Get the current date and time
                DateTime currentDateTime = DateTime.Now;

                // Find User Events for the given email
                var joinedEvents = context.JoinedEvents
                    .Where(ea => ea.userEmail == email)
                    .ToList();

                // Get a list of eventIds associated with the user
                List<int> eventIds = joinedEvents.Select(ea => ea.eventId).ToList();

                // Retrieve events with the specified eventIds that are in the future
                var eventsOfUser = context.Events
                    .Where(e => eventIds.Contains(e.eventId) &&
                           (e.date > currentDateTime.Date ||
                            (e.date == currentDateTime.Date && e.time.TimeOfDay > currentDateTime.TimeOfDay)))
                    .OrderByDescending(e => e.date)
                    .ThenByDescending(e => e.time)
                    .Take(10)
                    .ToList();

                return eventsOfUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public List<Event> GetPastEventsOfUser(string email, ConnectionFactory context)
        {
            try
            {
                // Get the current date and time
                DateTime currentDateTime = DateTime.Now;

                // Query database to get the past ten events attended by the user
                var pastEvents = context.JoinedEvents
                    .Where(je => je.userEmail == email)
                    .Join(
                        context.Events,
                        je => je.eventId,
                        e => e.eventId,
                        (je, e) => new { JoinedEvent = je, Event = e }
                      )
                      .Where(e => e.Event.date < currentDateTime.Date || (e.Event.date == currentDateTime.Date && e.Event.time.TimeOfDay < currentDateTime.TimeOfDay))
                      .OrderByDescending(e => e.Event.date)
                      .ThenByDescending(e => e.Event.time)
                      .Take(10)
                      .Select(e => e.Event)
                      .ToList();

                return pastEvents;
            }
            catch (Exception ex )
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
