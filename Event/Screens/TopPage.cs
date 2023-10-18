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
    public partial class TopPage : Form
    {
        public TopPage()
        {
            InitializeComponent();
        }

        bool openSideMenuBar;
        private void timerForSidebar_Tick(object sender, EventArgs e)
        {
            if (openSideMenuBar)
            {
                sideMenuBar.Width -= 10;
                if (sideMenuBar.Width == sideMenuBar.MinimumSize.Width)
                {
                    openSideMenuBar = false;
                    timerForSidebar.Stop();
                }
            }
            else
            {
                sideMenuBar.Width += 10;
                if (sideMenuBar.Width == sideMenuBar.MaximumSize.Width)
                {
                    openSideMenuBar = true;
                    timerForSidebar.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            timerForSidebar.Start();
        }
    }
}
