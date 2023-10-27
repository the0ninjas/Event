﻿using EventManagementSystem.Models;
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

        public List<Event> GetEventsOfAdmin(string email)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    // Find EventAdmins for the given email
                    var createdEvents = context.CreatedEvents
                        .Where(ea => ea.userEmail == email)
                        .ToList();

                    // Get the list of eventIds associated with the admin
                    List<int> eventIds = createdEvents.Select(ea => ea.eventId).ToList();

                    // Retrieve events with the specified eventIds
                    var eventsOfAdmin = context.Events
                        .Where(e => eventIds.Contains(e.eventId))
                        .ToList();

                    return eventsOfAdmin;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }


        public bool deleteEventAdmin(int eventId)
        {
            try
            {
                using (var context = new ConnectionFactory())
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}

