﻿using System;
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
        public mainPage()
        {
            InitializeComponent();
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
    }
}
