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

            //joinedEventHScrollBar.Value = joinedEventFlowLayoutPanel.HorizontalScroll.Value;
            //joinedEventHScrollBar.Minimum = joinedEventFlowLayoutPanel.HorizontalScroll.Minimum;
            //joinedEventHScrollBar.Maximum = joinedEventFlowLayoutPanel.HorizontalScroll.Maximum;

            //joinedEventFlowLayoutPanel.ControlAdded += joinedEventFlowLayoutPanel_ControlAdded;
            //joinedEventFlowLayoutPanel.ControlRemoved += joinedEventFlowLayoutPanel_ControlRemoved;
        }

        //private void joinedEventFlowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        //{
        //    joinedEventHScrollBar.Maximum = joinedEventFlowLayoutPanel.HorizontalScroll.Maximum;
        //}

        //private void joinedEventFlowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        //{
        //    joinedEventHScrollBar.Minimum = joinedEventFlowLayoutPanel.HorizontalScroll.Minimum;
        //}

        //private void joinedEventHScrollBar_Scroll(object sender, ScrollEventArgs e)
        //{
        //    joinedEventFlowLayoutPanel.HorizontalScroll.Value = joinedEventHScrollBar.Value;
        //}

        private void Dashboard_Load(object sender, EventArgs e)
        {
            populateMyJoinedEventCard();
            populateMyCreatedEventCard();
            populateUpcomingEventCard();
        }

        //Populate my joined event EventCard
        private void populateMyJoinedEventCard()
        {
            // populate it here  
            EventCard[] myJoinedEvents = new EventCard[20];

            // loop through each event
            for (int i = 0; i < myJoinedEvents.Length; i++)
            {
                myJoinedEvents[i] = new EventCard();
                myJoinedEvents[i].Title = "Title";
                myJoinedEvents[i].Capacity = "Capacity";
                myJoinedEvents[i].Date = "Date";
                myJoinedEvents[i].Time = "Time";
                myJoinedEvents[i].Location = "Location";

                // add to joinedEventFlowLayoutPanel
                //if (joinedEventFlowLayoutPanel.Controls.Count > 0)
                //{
                //    joinedEventFlowLayoutPanel.Controls.Clear();
                //}
                //else
                joinedEventFlowLayoutPanel.Controls.Add(myJoinedEvents[i]);
            }
        }
        //Populate my joined event EventCard
        private void populateMyCreatedEventCard()
        {
            // populate it here  
            EventCard[] myCreatedEvents = new EventCard[20];

            // loop through each event
            for (int i = 0; i < myCreatedEvents.Length; i++)
            {
                myCreatedEvents[i] = new EventCard();
                myCreatedEvents[i].Title = "Title";
                myCreatedEvents[i].Capacity = "Capacity";
                myCreatedEvents[i].Date = "Date";
                myCreatedEvents[i].Time = "Time";
                myCreatedEvents[i].Location = "Location";

                // add to joinedEventFlowLayoutPanel
                //if (joinedEventFlowLayoutPanel.Controls.Count > 0)
                //{
                //    joinedEventFlowLayoutPanel.Controls.Clear();
                //}
                //else
                createdEventFlowLayoutPanel.Controls.Add(myCreatedEvents[i]);
            }
        }
        //Populate my joined event EventCard
        private void populateUpcomingEventCard()
        {
            // populate it here  
            EventCard[] myUpcomingEvents = new EventCard[20];

            // loop through each event
            for (int i = 0; i < myUpcomingEvents.Length; i++)
            {
                myUpcomingEvents[i] = new EventCard();
                myUpcomingEvents[i].Title = "Title";
                myUpcomingEvents[i].Capacity = "Capacity";
                myUpcomingEvents[i].Date = "Date";
                myUpcomingEvents[i].Time = "Time";
                myUpcomingEvents[i].Location = "Location";

                // add to joinedEventFlowLayoutPanel
                //if (joinedEventFlowLayoutPanel.Controls.Count > 0)
                //{
                //    joinedEventFlowLayoutPanel.Controls.Clear();
                //}
                //else
                upcomingEventFlowLayoutPanel.Controls.Add(myUpcomingEvents[i]);
            }
        }
    }
}
