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
    public partial class settingsPage : Form
    {
       
        public settingsPage()
        {
            InitializeComponent();
           

            if(Settings1.Default.user_data == rBtnNormal.Name)
            {
                rBtnNormal.Checked = true;
            }
            else if(Settings1.Default.user_data == rBtnEasy.Name)
            {
                rBtnEasy.Checked = true;
            }
            else if(Settings1.Default.user_data == rBtnHard.Name)
            {
                rBtnHard.Checked = true;
            }
            else if(Settings1.Default.user_data == rBtnCustom.Name)
            {
                rBtnCustom.Checked = true;
                (txBx_Mtrx1.Text) = Settings1.Default.data_custom_row.ToString();
                (txBx_Mtrx2.Text) = Settings1.Default.data_custom_clmn.ToString();
            }

            checkBox1.Checked = Settings1.Default.data_square;
            checkBox2.Checked = Settings1.Default.data_triangle;
            checkBox3.Checked = Settings1.Default.data_round;

            checkBox4.Checked = Settings1.Default.data_blue;
            checkBox5.Checked = Settings1.Default.data_green;
            checkBox6.Checked = Settings1.Default.data_purple;

        }

        private void rBtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnCustom.Checked)
            {
                
                //txBx_Mtrx1.Visible = true;
                //txBx_Mtrx2.Visible = true;
                txBx_Mtrx1.Focus();
                

            }
            else
            {
                //txBx_Mtrx1.Visible = false;
                //txBx_Mtrx2.Visible = false;
            }
          

        }

        private void txBx_Mtrx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBx_Mtrx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rBtnNormal_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rBtnEasy_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rBtnHard_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rBtnNormal.Checked)
            {
                Settings1.Default.user_data = rBtnNormal.Name;
            }
            else if (rBtnHard.Checked)
            {
                Settings1.Default.user_data = rBtnHard.Name;
            }
            else if (rBtnEasy.Checked)
            {
                Settings1.Default.user_data = rBtnEasy.Name;
            }
            else if (rBtnCustom.Checked)
            {
                Settings1.Default.user_data = rBtnCustom.Name;
                Settings1.Default.data_custom_row = Int32.Parse(txBx_Mtrx1.Text);
                Settings1.Default.data_custom_clmn = Int32.Parse(txBx_Mtrx2.Text);

            }
            
            Settings1.Default.data_blue = checkBox4.Checked;
            Settings1.Default.data_green = checkBox5.Checked;
            Settings1.Default.data_purple = checkBox6.Checked;

            Settings1.Default.data_square = checkBox1.Checked;
            Settings1.Default.data_triangle = checkBox2.Checked;
            Settings1.Default.data_round = checkBox3.Checked;
            Settings1.Default.Save();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void settingsPage_Load(object sender, EventArgs e)
        {

        }
    }
}
