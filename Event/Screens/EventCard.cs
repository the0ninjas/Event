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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EventManagementSystem.Screens
{
    public partial class EventCard : UserControl
    {
        public EventCard()
        {
            InitializeComponent();
        }

        private int eventId;
        public int EventId
        {
            get { return eventId; }
            set
            {
                eventId = value;
            }
        }

        private string eventTitle;
        public string EventTitle
        {
            get { return eventTitle; }
            set
            {
                eventTitle = value;
                cardPictureBox.Invalidate();  // Triggers the cardPictureBox to redraw itself.
            }
        }

        private string eventCapacity;
        public string EventCapacity
        {
            get { return eventCapacity; }
            set
            {
                eventCapacity = value;
                cardPictureBox.Invalidate();  // Triggers the cardPictureBox to redraw itself.
            }
        }

        private string eventDate;
        public string EventDate
        {
            get { return eventDate; }
            set
            {
                eventDate = value;
                cardPictureBox.Invalidate();  // Triggers the cardPictureBox to redraw itself.
            }
        }

        private string eventTime;
        public string EventTime
        {
            get { return eventTime; }
            set
            {
                eventTime = value;
                cardPictureBox.Invalidate();  // Triggers the cardPictureBox to redraw itself.
            }
        }

        private string eventLocation;
        public string EventLocation
        {
            get { return eventLocation; }
            set
            {
                eventLocation = value;
                cardPictureBox.Invalidate();  // Triggers the cardPictureBox to redraw itself.
            }
        }

        private Image _picture;
        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; cardPictureBox.Image = value; }
        }

        // Directly draw title, capacity, date, time, and location on the pictureBox
        private void cardPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Segoe UI", 10, FontStyle.Bold);
            Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Brush textBrush = new SolidBrush(Color.Black);

            //3000x2000 setting
            //e.Graphics.DrawString(EventTitle, titleFont, textBrush, new PointF(25, 27));
            //e.Graphics.DrawString(EventCapacity, font, textBrush, new PointF(369, 27));
            //e.Graphics.DrawString(EventDate, font, textBrush, new PointF(25, 249));
            //e.Graphics.DrawString(EventTime, font, textBrush, new PointF(160, 249));
            //e.Graphics.DrawString(EventLocation, font, textBrush, new PointF(25, 200));

            //1920x1080 setting
            e.Graphics.DrawString(EventTitle, titleFont, textBrush, new PointF(12, 19));
            e.Graphics.DrawString(EventCapacity, font, textBrush, new PointF(250, 24));
            e.Graphics.DrawString(EventDate, font, textBrush, new PointF(12, 162));
            e.Graphics.DrawString(EventTime, font, textBrush, new PointF(117, 162));
            e.Graphics.DrawString(EventLocation, font, textBrush, new PointF(12, 132));

            textBrush.Dispose();
        }

        public void cardJoinButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    // Retrieve the EventCard by navigating up the parent hierarchy
                    Control parent = ((Button)sender).Parent;
                    while (!(parent is EventCard) && parent != null)
                    {
                        parent = parent.Parent;
                    }

                    if (parent is EventCard clickedCard)
                    {
                        int eventIdToJoin = clickedCard.EventId;

                        User authenticateUser = UserSession.AuthenticatedUser;

                        JoinedEventsRepo joinedEventsRepo = new JoinedEventsRepo();
                        joinedEventsRepo.joinEvent(eventIdToJoin, authenticateUser.email, context);

                        EventRepo eventRepo = new EventRepo();
                        Event joinedEvent = eventRepo.getEventById(eventIdToJoin, context);

                        // Initialize the EmailSender with your SMTP server details and credentials
                        EmailSender emailSender = new EmailSender("smtp.gmail.com", 587, "eventhubforyou@gmail.com", "oajb cbpz cflk oyly");

                        // Get email body
                        string emailBody = emailSender.getBodyEmailEventJoined(authenticateUser.firstName, joinedEvent);

                        // Send an email
                        emailSender.SendEmail(authenticateUser.email, "Event Successfully Joined!", emailBody);

                        // Refreshing the dashboard 
                        // Find the TopPage instance
                        Control currentControl = ((Button)sender).Parent;
                        while (!(currentControl is TopPage) && currentControl != null)
                        {
                            currentControl = currentControl.Parent;
                        }

                        if (currentControl is TopPage topPage)
                        {
                            // Remove the existing Dashboard from topPagePane
                            foreach (Control ctrl in topPage.topPagePane.Controls)
                            {
                                if (ctrl is Dashboard)
                                {
                                    ctrl.Dispose();
                                    break;
                                }
                            }

                            // Create and show a new Dashboard
                            Dashboard dashboardForm = new Dashboard
                            {
                                TopLevel = false,
                                FormBorderStyle = FormBorderStyle.None,
                                Dock = DockStyle.Fill
                            };

                            topPage.topPagePane.Controls.Add(dashboardForm);
                            dashboardForm.BringToFront();
                            dashboardForm.Show();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Failed to find the EventCard associated with the clicked button.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void cardLeaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    // Retrieve the EventCard by navigating up the parent hierarchy
                    Control parent = ((Button)sender).Parent;
                    while (!(parent is EventCard) && parent != null)
                    {
                        parent = parent.Parent;
                    }

                    if (parent is EventCard clickedCard)
                    {
                        int eventIdToLeave = clickedCard.EventId;

                        User authenticateUser = UserSession.AuthenticatedUser;

                        JoinedEventsRepo joinedEventsRepo = new JoinedEventsRepo();
                        bool success = joinedEventsRepo.leaveEvent(eventIdToLeave, authenticateUser.email, context);

                        if (success)
                        {

                            EventRepo eventRepo = new EventRepo();
                            Event leftEvent = eventRepo.getEventById(eventIdToLeave, context);

                            // Initialize the EmailSender with your SMTP server details and credentials
                            EmailSender emailSender = new EmailSender("smtp.gmail.com", 587, "eventhubforyou@gmail.com", "oajb cbpz cflk oyly");

                            // Get email body
                            string emailBody = emailSender.getBodyEmailEventLeft(authenticateUser.firstName, leftEvent);

                            // Send an email
                            emailSender.SendEmail(authenticateUser.email, "Event Successfully Left!", emailBody);

                            // Refreshing the dashboard 
                            // Find the TopPage instance
                            Control currentControl = ((Button)sender).Parent;
                            while (!(currentControl is TopPage) && currentControl != null)
                            {
                                currentControl = currentControl.Parent;
                            }

                            if (currentControl is TopPage topPage)
                            {
                                // Remove the existing Dashboard from topPagePane
                                foreach (Control ctrl in topPage.topPagePane.Controls)
                                {
                                    if (ctrl is Dashboard)
                                    {
                                        ctrl.Dispose();
                                        break;
                                    }
                                }

                                // Create and show a new Dashboard
                                Dashboard dashboardForm = new Dashboard
                                {
                                    TopLevel = false,
                                    FormBorderStyle = FormBorderStyle.None,
                                    Dock = DockStyle.Fill
                                };

                                topPage.topPagePane.Controls.Add(dashboardForm);
                                dashboardForm.BringToFront();
                                dashboardForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to leave event. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Failed to find the EventCard associated with the clicked button.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.WriteLine("Leave button pressed");
        }

        public void cardDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ConnectionFactory())
                {
                    // Retrieve the EventCard by navigating up the parent hierarchy
                    Control parent = ((Button)sender).Parent;
                    while (!(parent is EventCard) && parent != null)
                    {
                        parent = parent.Parent;
                    }

                    if (parent is EventCard clickedCard)
                    {
                        int eventIdToDelete = clickedCard.EventId;

                        User authenticateUser = UserSession.AuthenticatedUser;

                        EventRepo eventRepo = new EventRepo();
                        Event deletedEvent = eventRepo.getEventById(eventIdToDelete, context);

                        
                        bool success = eventRepo.deleteEvent(eventIdToDelete, context);

                        if (success)
                        {


                            // Initialize the EmailSender with your SMTP server details and credentials
                            EmailSender emailSender = new EmailSender("smtp.gmail.com", 587, "eventhubforyou@gmail.com", "oajb cbpz cflk oyly");

                            // Get email body
                            string emailBody = emailSender.getBodyEmailEventLeft(authenticateUser.firstName, deletedEvent);

                            // Send an email
                            emailSender.SendEmail(authenticateUser.email, "Event Successfully Deleted!", emailBody);
                            // Refreshing the dashboard 
                            // Find the TopPage instance
                            Control currentControl = ((Button)sender).Parent;
                            while (!(currentControl is TopPage) && currentControl != null)
                            {
                                currentControl = currentControl.Parent;
                            }

                            if (currentControl is TopPage topPage)
                            {
                                // Remove the existing Dashboard from topPagePane
                                foreach (Control ctrl in topPage.topPagePane.Controls)
                                {
                                    if (ctrl is Dashboard)
                                    {
                                        ctrl.Dispose();
                                        break;
                                    }
                                }

                                // Create and show a new Dashboard
                                Dashboard dashboardForm = new Dashboard
                                {
                                    TopLevel = false,
                                    FormBorderStyle = FormBorderStyle.None,
                                    Dock = DockStyle.Fill
                                };

                                topPage.topPagePane.Controls.Add(dashboardForm);
                                dashboardForm.BringToFront();
                                dashboardForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the event. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Failed to find the EventCard associated with the clicked button.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.WriteLine("Delete button pressed");
        }
    }
}
