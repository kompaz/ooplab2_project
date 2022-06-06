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
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ooplab
{
    public partial class Profile : Form
    {
        

        public Profile()
        {
            InitializeComponent();

        }

        private void initInfo()
        {
           

            //commanupdate.Parameters.AddWithValue("@puserName", txtUsername.Text);
            //commanupdate.Parameters.AddWithValue("@ppassword", sha256_hash(txtPassword.Text));
            //commanupdate.Parameters.AddWithValue("@pnamesurname", txtNameSurname.Text);
            //commanupdate.Parameters.AddWithValue("@pphoneNumber", txtPhone.Text);
            //commanupdate.Parameters.AddWithValue("@paddress", txtAddress.Text);
            //commanupdate.Parameters.AddWithValue("@pcity", txtCity.Text);
            //commanupdate.Parameters.AddWithValue("@pcountry", txtCountry.Text);
            //commanupdate.Parameters.AddWithValue("@pmail", txtMail.Text);

            //commanupdate.ExecuteNonQuery();

        }

        //private void initInfo()
        //{
        //    XmlDocument xdosya = new XmlDocument();
        //    xdosya.Load(@"veri.xml");
        //    foreach (XmlNode node in xdosya.DocumentElement)
        //    {
        //        if ((node["Username"].InnerText) == Username)
        //        {
        //            txtUsername.Text = node["Username"].InnerText;
        //            txtPassword.Text = node["Password"].InnerText;
        //            txtNameSurname.Text = node["Name-Surname"].InnerText;
        //            txtPhone.Text = node["Phone-Number"].InnerText;
        //            txtAddress.Text = node["Address"].InnerText;
        //            txtCity.Text = node["City"].InnerText;
        //            txtCountry.Text = node["Country"].InnerText;
        //            txtMail.Text = node["E-mail"].InnerText;
                    
        //        }
        //        //Console.WriteLine((node["Username"].InnerText),Environment.NewLine);
        //        //Console.WriteLine((node["Password"].InnerText),Environment.NewLine);
        //    }
            
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commanupdate = new SqlCommand("Update userTable set userName=@puserName , userPassword=@ppassword , namesurname= @pnamesurname , phoneNumber= @pphoneNumber, address= @paddress , city =@pcity, country = @pcountry, email = @pmail where username= @puserName", sqlOperations.cnn);

            sqlOperations.CheckConnection(sqlOperations.cnn);

            string PName = Settings1.Default.lastpword;
            

            if(PName == txtSifre.Text || PName == (null))
            {
                commanupdate.Parameters.AddWithValue("@puserName", txtUsername.Text);
                commanupdate.Parameters.AddWithValue("@ppassword", txtPassword.Text);
                commanupdate.Parameters.AddWithValue("@pnamesurname", txtNameSurname.Text);
                commanupdate.Parameters.AddWithValue("@pphoneNumber", txtPhone.Text);
                commanupdate.Parameters.AddWithValue("@paddress", txtAddress.Text);
                commanupdate.Parameters.AddWithValue("@pcity", txtCity.Text);
                commanupdate.Parameters.AddWithValue("@pcountry", txtCountry.Text);
                commanupdate.Parameters.AddWithValue("@pmail", txtMail.Text);

                commanupdate.ExecuteNonQuery();

                MessageBox.Show("Update was succesfully complate.");
            }
            else
            {
                MessageBox.Show("PLEASE ENTER YOUR PASSWORD CORRECTLY!!");
            }
            
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    XmlDocument xdosya = new XmlDocument();
        //    xdosya.Load(@"veri.xml");
            

        //    foreach (XmlNode node in xdosya.DocumentElement)
        //    {
        //        if ((node["Password"].InnerText) == sha256_hash(txtSifre.Text))
        //        {
        //            XDocument xUpdate = XDocument.Load(@"veri.xml");
        //            XElement elementUpdate = xUpdate.Element("Users").Elements("User").FirstOrDefault(x => x.Element("Username").Value == txtUsername.Text);

        //            if (elementUpdate != null)
        //            {
        //                elementUpdate.SetElementValue("Password", txtPassword.Text);
        //                elementUpdate.SetElementValue("Name-Surname", txtNameSurname.Text);
        //                elementUpdate.SetElementValue("Phone-Number", txtPhone.Text);
        //                elementUpdate.SetElementValue("Address", txtAddress.Text);
        //                elementUpdate.SetElementValue("City", txtCity.Text);
        //                elementUpdate.SetElementValue("Country", txtCountry.Text);
        //                elementUpdate.SetElementValue("E-mail", txtMail.Text);
        //                xUpdate.Save(@"veri.xml");
        //            }
                    
        //        }
               
        //        //Console.WriteLine((node["Username"].InnerText),Environment.NewLine);
        //        //Console.WriteLine((node["Password"].InnerText),Environment.NewLine);
        //    }

        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uName = Settings1.Default.username;
            this.txtUsername.Text = uName;
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ABOUT THAT?", "WARNING!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand commanDelete = new SqlCommand("Delete from userTable where userName=@puserName", sqlOperations.cnn);

                sqlOperations.CheckConnection(sqlOperations.cnn);

                commanDelete.Parameters.AddWithValue("@puserName", txtUsername.Text);

                commanDelete.ExecuteNonQuery();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }


        }
       


        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            string uName = Settings1.Default.username;
            this.txtUsername.Text = uName;

            sqlOperations.CheckConnection(sqlOperations.cnn);

            SqlCommand commaninfo = new SqlCommand("Select * from userTable where userName = @puserName", sqlOperations.cnn); 

            commaninfo.Parameters.AddWithValue("@puserName", txtUsername.Text);
            commaninfo.CommandType = CommandType.Text;

            SqlDataReader da = commaninfo.ExecuteReader();

            da.Read();

            txtNameSurname.Text = da["namesurname"].ToString();
            txtPhone.Text = da["phoneNumber"].ToString();
            txtAddress.Text = da["address"].ToString();
            txtCity.Text = da["city"].ToString();
            txtCountry.Text = da["country"].ToString();
            txtMail.Text = da["email"].ToString();
            
            da.Close();
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
    }
}
