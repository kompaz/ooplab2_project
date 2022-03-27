using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ooplab
{
    public partial class settingsPage : Form
    {
        public settingsPage()
        {
            InitializeComponent();
        }

        private void rBtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnCustom.Checked)
            {
                txBx_Mtrx1.Visible = true;
                txBx_Mtrx2.Visible = true;
            }
            else
            {
                txBx_Mtrx1.Visible = false;
                txBx_Mtrx2.Visible = false;
            }
        }

        private void txBx_Mtrx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBx_Mtrx2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
