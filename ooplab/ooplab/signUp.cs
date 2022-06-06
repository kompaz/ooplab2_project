using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using ooplab.Classes;

namespace ooplab
{
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void signUp_Load(object sender, EventArgs e)
        {
            //XmlTextWriter data = new XmlTextWriter(@"veri.xml", Encoding.UTF8);
            //data.Formatting = Formatting.Indented;
            //data.WriteStartDocument();
            //data.WriteStartElement("Users");
            //data.WriteStartElement("User");
            //data.WriteElementString("Username", "kmpz");
            //data.WriteElementString("Password", "1999");
            //data.WriteElementString("Name-Surname", "Sinan KOMPAS");
            //data.WriteElementString("PhoneNumber", "5458256769");
            //data.WriteEndElement();
            //data.WriteEndElement();
            //data.Close();
        }

        //private void btnEkle_Click(object sender, EventArgs e)
        //{
        //    XDocument xdosya = XDocument.Load(@"veri.xml");
        //    XElement rooelement = xdosya.Root;
        //    XElement element = new XElement("User");
        //    XElement username = new XElement("Username", txtUsername.Text);
        //    XElement password = new XElement("Password", sha256_hash(txtPassword.Text));
        //    XElement NSurname = new XElement("Name-Surname", txtNameSurname.Text);
        //    XElement phoneNUM = new XElement("Phone-Number", txtPhone.Text);
        //    XElement address = new XElement("Address", txtAddress.Text);
        //    XElement city = new XElement("City", txtCity.Text);
        //    XElement country = new XElement("Country", txtCountry.Text);
        //    XElement mail = new XElement("E-mail", txtMail.Text);
        //    element.Add(username, password, NSurname, phoneNUM, address, city, country, mail);
        //    rooelement.Add(element);
        //    xdosya.Save(@"veri.xml");
        //    MessageBox.Show("kayit eklendi.");

        //}

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand commdanAdd = new SqlCommand("Insert into userTable (userName,userPassword,namesurname,phoneNumber,address,city,country,email) values(@pusername,@ppassword,@pnamesurname,@pphoneNumber,@paddress,@pcity,@pcountry,@pmail)", sqlOperations.cnn);

            sqlOperations.CheckConnection(sqlOperations.cnn);

            commdanAdd.Parameters.AddWithValue("@pusername", txtUsername.Text);
            commdanAdd.Parameters.AddWithValue("@ppassword", txtPassword.Text);
            commdanAdd.Parameters.AddWithValue("@pnamesurname", txtNameSurname.Text);
            commdanAdd.Parameters.AddWithValue("@pphoneNumber", txtPhone.Text);
            commdanAdd.Parameters.AddWithValue("@paddress", txtAddress.Text);
            commdanAdd.Parameters.AddWithValue("@pcity", txtCity.Text);
            commdanAdd.Parameters.AddWithValue("@pcountry", txtCountry.Text);
            commdanAdd.Parameters.AddWithValue("@pmail", txtMail.Text);

            commdanAdd.ExecuteNonQuery();
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
