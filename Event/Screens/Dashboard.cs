using EventManagementSystem.Models;
using EventManagementSystem.Repository;
using EventManagementSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem.Screens
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        

        private void Dashboard_Load(object sender, EventArgs e)
        {
            populateMyJoinedEventCard();
            populateMyCreatedEventCard();
            populateUpcomingEventCard();
            populateMyPastEventCard();
        }

        //Populate my joined event EventCard
        private void populateMyJoinedEventCard()
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    User authenticateUser = UserSession.AuthenticatedUser;

                    JoinedEventsRepo joinedEventsRepo = new JoinedEventsRepo();
                    List<Event> joinedEvents = joinedEventsRepo.GetEventsOfUser(authenticateUser.email, context);

                    // loop through each event
                    foreach (var userEvent in joinedEvents)
                    {
                        EventCard eventCard = new EventCard();
                        eventCard.EventId = userEvent.eventId;
                        eventCard.Picture = (Bitmap)Properties.Resources.ResourceManager.GetObject(userEvent.imageName);
                        eventCard.EventTitle = userEvent.title;
                        eventCard.EventCapacity = Convert.ToString(userEvent.capacity);
                        eventCard.EventDate = userEvent.date.ToShortDateString();
                        eventCard.EventTime = userEvent.time.ToString("hh:mm tt");
                        eventCard.EventLocation = Convert.ToString(userEvent.location);

                        joinedEventFlowLayoutPanel.Controls.Add(eventCard);


                        eventCard.cardJoinButton.Click += CardJoinButton_Click;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void CardJoinButton_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Populate my created event EventCard
        private void populateMyCreatedEventCard()
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    User authenticateUser = UserSession.AuthenticatedUser;

                    CreatedEventRepo createdEventsRepo = new CreatedEventRepo();
                    List<Event> createdEvents = createdEventsRepo.GetEventsOfAdmin(authenticateUser.email, context);

                    // loop through each event
                    foreach (var userEvent in createdEvents)
                    {
                        EventCard eventCard = new EventCard();
                        eventCard.Picture = (Bitmap)Properties.Resources.ResourceManager.GetObject(userEvent.imageName);
                        eventCard.EventTitle = userEvent.title;
                        eventCard.EventCapacity = Convert.ToString(userEvent.capacity);
                        eventCard.EventDate = userEvent.date.ToShortDateString();
                        eventCard.EventTime = userEvent.time.ToString("hh:mm tt");
                        eventCard.EventLocation = Convert.ToString(userEvent.location);

                        createdEventFlowLayoutPanel.Controls.Add(eventCard);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            } 
        }

        //Populate my joined event EventCard
        private void populateUpcomingEventCard()
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    User authenticateUser = UserSession.AuthenticatedUser;

                    EventRepo eventsRepo = new EventRepo();
                    List<Event> createdEvents = eventsRepo.upcomingEvents(authenticateUser.email, context);

                    // loop through each event
                    foreach (var userEvent in createdEvents)
                    {
                        EventCard eventCard = new EventCard();
                        eventCard.Picture = (Bitmap)Properties.Resources.ResourceManager.GetObject(userEvent.imageName);
                        eventCard.EventTitle = userEvent.title;
                        eventCard.EventCapacity = Convert.ToString(userEvent.capacity);
                        eventCard.EventDate = userEvent.date.ToShortDateString();
                        eventCard.EventTime = userEvent.time.ToString("hh:mm tt");
                        eventCard.EventLocation = Convert.ToString(userEvent.location);

                        upcomingEventFlowLayoutPanel.Controls.Add(eventCard);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        private void populateMyPastEventCard()
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    User authenticateUser = UserSession.AuthenticatedUser;

                    JoinedEventsRepo joinedEventsRepo = new JoinedEventsRepo();
                    List<Event> joinedPastEvents = joinedEventsRepo.GetPastEventsOfUser(authenticateUser.email, context);

                    // loop through each event
                    foreach (var userEvent in joinedPastEvents)
                    {
                        EventCard eventCard = new EventCard();
                        eventCard.Picture = (Bitmap)Properties.Resources.ResourceManager.GetObject(userEvent.imageName);
                        eventCard.EventTitle = userEvent.title;
                        eventCard.EventCapacity = Convert.ToString(userEvent.capacity);
                        eventCard.EventDate = userEvent.date.ToShortDateString();
                        eventCard.EventTime = userEvent.time.ToString("hh:mm tt");
                        eventCard.EventLocation = Convert.ToString(userEvent.location);

                        joinedEventFlowLayoutPanel.Controls.Add(eventCard);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
