using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ooplab
{
    public partial class mainPage : Form
    {
        private string username;
        public mainPage(string Username)
        {
            InitializeComponent();
            username = Username;
            if (username != "admin")
            {
                btnAdmins.Visible = false;
            }
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsPage settings = new settingsPage();
            settings.ShowDialog();
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            AdminPage admMenu = new AdminPage();

            admMenu.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Profile profileScreen = new Profile(username);
            profileScreen.Show();
        }
    }
}
