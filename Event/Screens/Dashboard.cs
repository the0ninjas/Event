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



        public void Dashboard_Load(object sender, EventArgs e)
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

                    if (joinedEvents.Count == 0)
                    {
                        // display an empty eventCard

                        {
                            //EventCard eventCard = new EventCard();
                            //eventCard.EventTitle = "No joined event";
                            //eventCard.cardJoinButton.Enabled = false;

                            //joinedEventFlowLayoutPanel.Controls.Add(eventCard);
                        };

                    }

                    else
                    {
                        // loop through each event
                        foreach (var userEvent in joinedEvents)
                        {
                            EventCard eventCard = new EventCard();
                            eventCard.EventId = userEvent.eventId;
                            eventCard.Picture = (Bitmap)Properties.Resources.ResourceManager.GetObject(userEvent.imageName);
                            eventCard.EventTitle = userEvent.title;
                            eventCard.EventCapacity = Convert.ToString(userEvent.registrations + " / " + userEvent.capacity);
                            eventCard.EventDate = userEvent.time.ToShortDateString();
                            eventCard.EventTime = userEvent.time.ToString("hh:mm tt");
                            eventCard.EventLocation = Convert.ToString(userEvent.location);
                            eventCard.cardJoinButton.Visible = false;
                            eventCard.cardDeleteButton.Visible = false;

                            joinedEventFlowLayoutPanel.Controls.Add(eventCard);

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
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

                    if (createdEvents.Count == 0)
                    // populate an empty eventCard
                    {
                        //EventCard eventCard = new EventCard();
                        //eventCard.EventTitle = "No created event";
                        //eventCard.cardJoinButton.Enabled = false;

                        //createdEventFlowLayoutPanel.Controls.Add(eventCard);
                    }
                    else
                        // loop through each event
                        foreach (var userEvent in createdEvents)
                        {
                            EventCard eventCard = new EventCard();
                            eventCard.EventId = userEvent.eventId;
                            eventCard.Picture = (Bitmap)Properties.Resources.ResourceManager.GetObject(userEvent.imageName);
                            eventCard.EventTitle = userEvent.title;
                            eventCard.EventCapacity = Convert.ToString(userEvent.registrations + " / " + userEvent.capacity);
                            eventCard.EventDate = userEvent.time.ToShortDateString();
                            eventCard.EventTime = userEvent.time.ToString("hh:mm tt");
                            eventCard.EventLocation = Convert.ToString(userEvent.location);
                            eventCard.cardJoinButton.Visible = false;
                            eventCard.cardLeaveButton.Visible = false;

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


                    if (createdEvents.Count == 0l)
                    // populate an empty eventCard
                    {
                        //EventCard eventCard = new EventCard();
                        //eventCard.EventTitle = "No upcoming event";
                        //eventCard.cardJoinButton.Enabled = false;

                        //upcomingEventFlowLayoutPanel.Controls.Add(eventCard);
                    }
                    else
                        // loop through each event
                        foreach (var userEvent in createdEvents)
                        {
                            EventCard eventCard = new EventCard();
                            eventCard.EventId = userEvent.eventId;
                            eventCard.Picture = (Bitmap)Properties.Resources.ResourceManager.GetObject(userEvent.imageName);
                            eventCard.EventTitle = userEvent.title;
                            eventCard.EventCapacity = Convert.ToString(userEvent.registrations + " / " + userEvent.capacity);
                            eventCard.EventDate = userEvent.time.ToShortDateString();
                            eventCard.EventTime = userEvent.time.ToString("hh:mm tt");
                            eventCard.EventLocation = Convert.ToString(userEvent.location);
                            eventCard.cardLeaveButton.Visible = false;
                            eventCard.cardDeleteButton.Visible = false;

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


                    if (joinedPastEvents.Count == 0)
                    // populate empty eventCard
                    {
                        //EventCard eventCard = new EventCard();
                        //eventCard.EventTitle = "No past event";
                        //eventCard.cardJoinButton.Enabled = false;

                        //joinedEventFlowLayoutPanel.Controls.Add(eventCard);
                    }
                    else
                        // loop through each event
                        foreach (var userEvent in joinedPastEvents)
                        {
                            EventCard eventCard = new EventCard();
                            eventCard.EventId = userEvent.eventId;
                            eventCard.Picture = (Bitmap)Properties.Resources.ResourceManager.GetObject(userEvent.imageName);
                            eventCard.EventTitle = userEvent.title;
                            eventCard.EventCapacity = Convert.ToString(userEvent.registrations + " / " + userEvent.capacity);
                            eventCard.EventDate = userEvent.time.ToShortDateString();
                            eventCard.EventTime = userEvent.time.ToString("hh:mm tt");
                            eventCard.EventLocation = Convert.ToString(userEvent.location);
                            eventCard.cardJoinButton.Visible = false;
                            eventCard.cardLeaveButton.Visible = false;
                            eventCard.cardDeleteButton.Visible = false;

                            myPastEventFlowLayoutPanel.Controls.Add(eventCard);
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
