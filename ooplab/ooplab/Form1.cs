using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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

            textBox1.Text = Settings1.Default.username;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          if(!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text,"[a-zA-Z]"))
            {
                textBox1.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            for (int i=0;i<userList.Count;i++)
            {
                if(userList[i].Username == textBox1.Text && userList[i].Password == textBox2.Text)
                {
                    
                    mainPage menu = new mainPage();
                    //menu.Show();
                    
                    Settings1.Default.username = textBox1.Text;
                    Settings1.Default.Save();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                   
                    
                }
            }
            MessageBox.Show("Username and password not match");

        }

        private void cB_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cB_showPassword.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            signUp register = new signUp();

            register.ShowDialog();


        }
    }
}