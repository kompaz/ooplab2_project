﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab
{
    public partial class Form1 : Form
    {
        private List<user> userList = new List<user>();
        public Form1()
        {
            InitializeComponent();
            userList.Add(new user("admin", "admin", true));
            userList.Add(new user("user", "user", false));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<userList.Count;i++)
            {
                if(userList[i].Username == textBox1.Text && userList[i].Password == textBox2.Text)
                {
                    mainPage menu = new mainPage();
                    //menu.Show();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
            }
            MessageBox.Show("Username and password not match");
        }
    }
}