using ooplab.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            SqlCommand commandList = new SqlCommand("Select userPassword from userTable where userName like '" + textBox1.Text + "'", sqlOperations.cnn);

            sqlOperations.CheckConnection(sqlOperations.cnn);

            SqlDataReader dr = commandList.ExecuteReader();

            dr.Read();
            if (textBox2.Text == dr["userPassword"].ToString())
            {
                mainPage menu = new mainPage(textBox1.Text);
                Settings1.Default.username = textBox1.Text;
                Settings1.Default.lastpword = textBox2.Text;
                Settings1.Default.Save();

                this.Hide();
                menu.ShowDialog();

                this.Close();
                dr.Close();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Username and password not match");
            }


            //XmlDocument xdosya = new XmlDocument();
            //xdosya.Load(@"veri.xml");
            //foreach (XmlNode node in xdosya.DocumentElement)
            //{
            //    if ((node["Username"].InnerText) == textBox1.Text && node["Password"].InnerText == sha256_hash(textBox2.Text))
            //    {
            //        mainPage menu = new mainPage(node["Username"].InnerText);
            //        
            //        this.Hide();

            //        menu.ShowDialog();
            //        //Console.WriteLine((node["Username"].InnerText),Environment.NewLine);
            //        //Console.WriteLine((node["Password"].InnerText),Environment.NewLine);

            //        this.Close();
            //    }

            //}


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
        public static String sha256_hash(String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (System.Security.Cryptography.SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }

        private void btnAboutGame_Click_1(object sender, EventArgs e)
        {
            aboutGame credits = new aboutGame();
            credits.ShowDialog();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            helpPage help = new helpPage();
            help.ShowDialog();
        }
    }
}