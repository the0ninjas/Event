using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagementSystem.Repository
{
    public class EventRepo
    {
        private List<Event> Events = new List<Event>();

        // Function to save a new event to database
        public bool createEvent(Event newEvent, ConnectionFactory context)
        {
            try
            {
                            
                context.Events.Add(newEvent);
                context.SaveChanges();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        // Function to get an event by passing its id
        public Event getEventById(int eventId, ConnectionFactory context)
        {
            try
            {
                Event foundEvent = context.Events.FirstOrDefault(u => u.eventId == eventId);
                return foundEvent;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        
        public List<Event> upcomingEvents(string email, ConnectionFactory context) 
        {
            try 
            {
                // Get the current date and time
                DateTime currentDateTime = DateTime.Now;

                // Query the database to get the next ten future events that are not yet full
               
                var upcomingEvents = context.Events
                    .Where(e => e.time > DateTime.Now)
                    .Where(e => !context.JoinedEvents.Any(je => je.eventId == e.eventId && je.userEmail == email))
                    .Where(e => e.registrations < e.capacity)
                    .OrderBy(e => e.time)
                    .Take(10)
                    .ToList();

                return upcomingEvents;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        // Function to update the properties of an event -- not used
        public Event updateEvent(Event updatedEvent)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {

                    Event existingEvent = context.Events.FirstOrDefault(u => u.eventId == updatedEvent.eventId);

                    if (existingEvent != null)
                    {
                        existingEvent.title = updatedEvent.title;
                        existingEvent.time = updatedEvent.time;
                        existingEvent.location = updatedEvent.location;
                        existingEvent.capacity = updatedEvent.capacity;
                        existingEvent.registrations = updatedEvent.registrations;
                        
                        
                        context.SaveChanges();
                        return existingEvent;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        // Increase the number of registrations of an event, when a user joins the event
        public bool eventRegistration(int eventId, ConnectionFactory context)
        {
            try
            {
                Event existingEvent = context.Events.FirstOrDefault(u => u.eventId == eventId);

                if (existingEvent != null)
                {
                    existingEvent.registrations += 1;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;

            }
        }

        // Decrease the number of registrations of an event, when a user leaves the event
        public bool eventDeRegistration(int eventId, ConnectionFactory context)
        {
            try
            {
                Event existingEvent = context.Events.FirstOrDefault(u => u.eventId == eventId);

                if (existingEvent != null)
                {
                    existingEvent.registrations -= 1;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;

            }
        }


        // Delete an event with a specific id
        public bool deleteEvent(int eventId, ConnectionFactory context)
        {
            try
            {
                // Get the event that shall be deleted from database
                Event eventToDelete = context.Events.FirstOrDefault(u => u.eventId == eventId);

                // Check if an event has been returned
                if (eventToDelete != null)
                {
                    // Delete event itself
                    context.Events.Remove(eventToDelete);

                    // Remove the event for all users that have joined it already
                    JoinedEventsRepo joinedEventsRepo = new JoinedEventsRepo();
                    joinedEventsRepo.removeAllUserfromEvent(eventId, context);

                    // Remove the event for the user who created the event
                    CreatedEventRepo createdEventRepo = new CreatedEventRepo();
                    createdEventRepo.deleteEvent(eventId, context);

                    context.SaveChanges();

                    return true;
                }
                else
                {
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