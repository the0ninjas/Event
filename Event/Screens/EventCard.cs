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
    public partial class EventCard : UserControl
    {
        public EventCard()
        {
            InitializeComponent();
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

        private void cardPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Segoe UI", 10, FontStyle.Bold);
            Brush textBrush = new SolidBrush(Color.Black);

            e.Graphics.DrawString(EventTitle, font, textBrush, new PointF(25, 27));
            e.Graphics.DrawString(EventCapacity, font, textBrush, new PointF(369, 27));
            e.Graphics.DrawString(EventDate, font, textBrush, new PointF(25, 249));
            e.Graphics.DrawString(EventTime, font, textBrush, new PointF(154, 249));
            e.Graphics.DrawString(EventLocation, font, textBrush, new PointF(25, 200));

            textBrush.Dispose();
        }

        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; cardPictureBox.Image = value; }
        }


    }
}
