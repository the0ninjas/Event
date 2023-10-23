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

        private string _title;
        private string _capacity;
        private string _date;
        private string _time;
        private string _location;
        private Image _picture;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; cardTitleLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string Capacity
        {
            get { return _capacity; }
            set { _capacity = value; cardCapacityLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set { _date = value; cardDateLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string Time
        {
            get { return _time; }
            set { _time = value; cardTimeLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string Location
        {
            get { return _location; }
            set { _location = value; cardLocationLabel.Text = value; }
        }

        [Category("Custom Props")]
        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; cardPictureBox.Image = value; }
        }


    }
}
