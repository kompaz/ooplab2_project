using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            XDocument xdosya = XDocument.Load(@"veri.xml");
            XElement rooelement = xdosya.Root;
            XElement element = new XElement("User");
            XElement username = new XElement("Username", txtUsername.Text);
            XElement password = new XElement("Password", txtPassword.Text);
            XElement NSurname = new XElement("Name-Surname", txtNameSurname.Text);
            XElement phoneNUM = new XElement("Phone-Number", txtPhone.Text);
            XElement address = new XElement("Address", txtAddress.Text);
            XElement city = new XElement("City", txtCity.Text);
            XElement country = new XElement("Country", txtCountry.Text);
            XElement mail = new XElement("E-mail", txtMail.Text);
            element.Add(username, password, NSurname, phoneNUM, address, city, country, mail);
            rooelement.Add(element);
            xdosya.Save(@"veri.xml");
            MessageBox.Show("kayit eklendi.");

        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            XDocument xUpdate = XDocument.Load(@"veri.xml");
            XElement elementUpdate = xUpdate.Element("Users").Elements("User").FirstOrDefault(x => x.Element("Username").Value == txtUsername.Text);
            if (elementUpdate != null)
            {
                elementUpdate.SetElementValue("Password", txtPassword.Text);
                elementUpdate.SetElementValue("Name-Surname", txtNameSurname.Text);
                elementUpdate.SetElementValue("Phone-Number", txtPhone.Text);
                elementUpdate.SetElementValue("Address", txtAddress.Text);
                elementUpdate.SetElementValue("City", txtCity.Text);
                elementUpdate.SetElementValue("Country", txtCountry.Text);
                elementUpdate.SetElementValue("E-mail", txtMail.Text);
                xUpdate.Save(@"veri.xml");
            }
        }
    }
}
