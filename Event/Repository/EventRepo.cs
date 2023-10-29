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

                // Query the database to get the next ten upcoming events
               
                var upcomingEvents = context.Events
                    .Where(e => e.time > DateTime.Now)
                    .Where(e => !context.JoinedEvents.Any(je => je.eventId == e.eventId && je.userEmail == email))
                    .Where(e => e.registrations <= e.capacity)
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

        public void UpdateSearchResults(string searchString, ConnectionFactory context)
        {
            var searchResults = context.Events
                .Where(e => e.title.Contains(searchString) || e.time.ToString().Contains(searchString) || e.location.Contains(searchString))
                .OrderBy(e => e.time)
                .ToList();

            UpdateUIWithSearchResults(searchResults);

        }

        public void UpdateUIWithSearchResults(List<Event> searchResults)
        {
            // DataGridView.DataSource = searchResults;
        }
    }
}