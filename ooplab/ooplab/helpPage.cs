using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ooplab
{
    public partial class helpPage : Form
    {
        public helpPage()
        {
            InitializeComponent();
        }

        private void btn_aboutGame_Click(object sender, EventArgs e)
        {
            aboutGame credits = new aboutGame();
            credits.ShowDialog();
        }
    }
}
