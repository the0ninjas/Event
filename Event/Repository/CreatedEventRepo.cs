using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Repository
{
    public class CreatedEventRepo
    {
        private List<CreatedEvent> CreatedEvents = new List<CreatedEvent>();

        // Method to save the creator of the event
        public bool createEventAdmin(int createdEventId, string userEmail, ConnectionFactory context)
        {
            try
            {
                
                CreatedEvent newCreatedEvent = new CreatedEvent(createdEventId, userEmail);
                context.CreatedEvents.Add(newCreatedEvent);
                context.SaveChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        // Method to return whether an event has been created by a specific user
        public (bool eventOfAdmin, bool ErrorOccurred) EventofAdmin(int eventId, string userEmail, ConnectionFactory context)
        {
            try
            {
                var createdEvent = context.CreatedEvents
                    .Where(ea => ea.eventId == eventId && ea.userEmail == userEmail)
                    .ToList();

                return (eventOfAdmin: createdEvent.Any(), ErrorOccurred: false);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return (eventOfAdmin: false, ErrorOccurred: true);
            }
        }

        // Method to get all the events that a user has created
        public List<Event> GetEventsOfAdmin(string email, ConnectionFactory context)
        {
            try
            {
                
                // Find EventAdmins for the given email
                var createdEvents = context.CreatedEvents
                    .Where(ea => ea.userEmail == email)
                    .ToList();

                // Get the list of eventIds associated with the admin
                List<int> eventIds = createdEvents.Select(ea => ea.eventId).ToList();

                // Retrieve events with the specified eventIds that are in the future
                var eventsOfAdmin = context.Events
                    .Where(e => eventIds.Contains(e.eventId) &&
                           (e.time > DateTime.Now))
                    .OrderBy(e => e.time)
                    .ToList();

                return eventsOfAdmin;
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        // Method to delete that the user has been created a specific event
        public bool deleteEvent(int eventId, ConnectionFactory context)
        {
            try
            {

                var createdEventToDelete = context.CreatedEvents
                    .FirstOrDefault(ea => ea.eventId == eventId);

                if (createdEventToDelete != null)
                {
                    context.CreatedEvents.Remove(createdEventToDelete);

                    context.SaveChanges();

                    return true;
                }
                else
                {
                    // No EventAdmin found with the specified eventId
                    return false;
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

