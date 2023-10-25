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
    public partial class EventCreationForm : Form
    {
        public EventCreationForm()
        {
            InitializeComponent();
        }

        private void titleTextBox_Enter(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "Enter event title")
            {
                titleTextBox.Text = "";
                titleTextBox.ForeColor = Color.Black;
            }
        }

        private void titleTextBox_Leave(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "")
            {
                titleTextBox.Text = "Enter event title";
                titleTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void locationComboBox_Enter(object sender, EventArgs e)
        {
            if (locationComboBox.Text == "Select the location")
            {
                locationComboBox.Text = "";
                locationComboBox.ForeColor = Color.Black;
            }
        }

        private void locationComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(locationComboBox.Text))
            {
                locationComboBox.Text = "Select the location";
                locationComboBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void locationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(locationComboBox.Text) && locationComboBox.Text != "Select the location")
            {
                locationComboBox.ForeColor = Color.Black;
            }
        }

        private void capacityTextBox_Enter(object sender, EventArgs e)
        {
            if (capacityTextBox.Text == "Enter max capacity")
            {
                capacityTextBox.Text = "";
                capacityTextBox.ForeColor = Color.Black;
            }
        }

        private void capacityTextBox_Leave(object sender, EventArgs e)
        {
            if (capacityTextBox.Text == "")
            {
                capacityTextBox.Text = "Enter max capacity";
                capacityTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }

        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "Enter event description")
            {
                descriptionTextBox.Text = "";
                descriptionTextBox.ForeColor = Color.Black;
            }
        }

        private void descriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (descriptionTextBox.Text == "")
            {
                descriptionTextBox.Text = "Enter event description";
                descriptionTextBox.ForeColor = SystemColors.ScrollBar;
            }
        }
    }
}
