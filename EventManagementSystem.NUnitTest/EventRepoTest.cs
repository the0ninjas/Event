using NUnit.Framework;
using EventManagementSystem.Models;
using EventManagementSystem.Repository;
using System;
using System.Linq;
using EventManagementSystem.Utilities;
using Microsoft.EntityFrameworkCore;

namespace EventManagementSystem.Repository
{
    [TestFixture]
    public class EventRepoTests
    {
        [Test]
        public void CreateEvent_ValidEvent_ReturnsTrue()
        {
            // Arrange
            EventRepo eventRepo = new EventRepo();
            ConnectionFactory context = new ConnectionFactory();
            Event newEvent = new Event("Test Event", DateTime.Now, "Test Location", 100, "Test Image");

            // Act
            bool result = eventRepo.createEvent(newEvent, context);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void GetEventById_ExistingEvent_ReturnsEvent()
        {
            // Arrange
            EventRepo eventRepo = new EventRepo();
            ConnectionFactory context = new ConnectionFactory();
            Event newEvent = new Event("Test Event", DateTime.Now, "Test Location", 100, "Test Image");
            context.Events.Add(newEvent);
            context.SaveChanges();

            // Act
            Event result = eventRepo.getEventById(newEvent.eventId, context);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(newEvent.eventId, result.eventId);
        }

        [Test]
        public void UpcomingEvents_ValidEmail_ReturnsListOfEvents()
        {
            // Arrange
            EventRepo eventRepo = new EventRepo();
            ConnectionFactory context = new ConnectionFactory();
            string userEmail = "test@example.com";

            // Act
            List<Event> result = eventRepo.upcomingEvents(userEmail, context);

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void UpdateEvent_ExistingEvent_ReturnsUpdatedEvent()
        {
            // Arrange
            EventRepo eventRepo = new EventRepo();
            ConnectionFactory context = new ConnectionFactory();
            Event newEvent = new Event("Test Event", DateTime.Now, "Test Location", 100, "Test Image");
            context.Events.Add(newEvent);
            context.SaveChanges();
            Event updatedEvent = new Event("Updated Event", DateTime.Now, "Updated Location", 200, "Updated Image");

            // Act
            updatedEvent.eventId = newEvent.eventId;
            Event result = eventRepo.updateEvent(updatedEvent);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(updatedEvent.title, result.title);
        }

        [Test]
        public void EventRegistration_ExistingEvent_ReturnsTrue()
        {
            // Arrange
            EventRepo eventRepo = new EventRepo();
            ConnectionFactory context = new ConnectionFactory();
            Event newEvent = new Event("Test Event", DateTime.Now, "Test Location", 100, "Test Image");
            context.Events.Add(newEvent);
            context.SaveChanges();
            int eventId = newEvent.eventId;

            // Act
            bool result = eventRepo.eventRegistration(eventId, context);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteEvent_ExistingEvent_ReturnsTrue()
        {
            // Arrange
            EventRepo eventRepo = new EventRepo();
            ConnectionFactory context = new ConnectionFactory();
            Event newEvent = new Event("Test Event", DateTime.Now, "Test Location", 100, "Test Image");
            context.Events.Add(newEvent);
            context.SaveChanges();
            int eventId = newEvent.eventId;

            // Act
            bool result = eventRepo.deleteEvent(eventId, context);

            // Assert
            Assert.IsTrue(result);
        }
    }
}