using EventManagementSystem.Models;
using EventManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Repository
{
    public class EventRepo
    {
        private List<Event> Events = new List<Event>();

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

        public Event getEventById(int eventId, ConnectionFactory context)
        {
            try
            {
                    Event foundEvent = Events.Find(u => u.eventId == eventId);
                    return foundEvent;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }

        public List<Event> upcomingEvents(ConnectionFactory context) 
        {
            try 
            {
                // Get the current date and time
                DateTime currentDateTime = DateTime.Now;

                // Query the database to get the next ten upcoming events
                var upcomingEvents = context.Events
                    .Where(e => e.date > currentDateTime.Date || (e.date == currentDateTime.Date && e.time.TimeOfDay > currentDateTime.TimeOfDay))
                    .OrderBy(e => e.date)
                    .ThenBy(e => e.time)
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

        public Event updateEvent(Event updatedEvent)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {

                    Event existingEvent = Events.Find(u => u.eventId == updatedEvent.eventId);

                    if (existingEvent != null)
                    {
                        existingEvent.title = updatedEvent.title;
                        existingEvent.date = updatedEvent.date;
                        existingEvent.time = updatedEvent.time;
                        existingEvent.location = updatedEvent.location;
                        existingEvent.capacity = updatedEvent.capacity;
                        existingEvent.registrations = updatedEvent.registrations;
                        existingEvent.description = updatedEvent.description;
                        
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

        public bool deleteEvent(int eventId, ConnectionFactory context)
        {
            try
            {
                
                    Event eventToDelete = Events.Find(u => u.eventId == eventId);

                    if (eventToDelete != null)
                    {
                        context.Events.Remove(eventToDelete);
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