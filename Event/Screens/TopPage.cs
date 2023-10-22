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
                sideBarFlowLayoutPanel.Width -= 10;
                if (sideBarFlowLayoutPanel.Width == sideBarFlowLayoutPanel.MinimumSize.Width)
                {
                    openSideMenuBar = false;
                    timerForSidebar.Stop();
                }
            }
            else
            {
                sideBarFlowLayoutPanel.Width += 10;
                if (sideBarFlowLayoutPanel.Width == sideBarFlowLayoutPanel.MaximumSize.Width)
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
