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

namespace ooplab
{
    public partial class Profile : Form
    {
        private string Username;

        public Profile(string username)
        {
            InitializeComponent();
            Username = username;

            initInfo();
        }

        private void initInfo()
        {
            XmlDocument xdosya = new XmlDocument();
            xdosya.Load(@"veri.xml");
            foreach (XmlNode node in xdosya.DocumentElement)
            {
                if ((node["Username"].InnerText) == Username)
                {
                    txtUsername.Text = node["Username"].InnerText;
                    txtPassword.Text = node["Password"].InnerText;
                    txtNameSurname.Text = node["Name-Surname"].InnerText;
                    txtPhone.Text = node["Phone-Number"].InnerText;
                    txtAddress.Text = node["Address"].InnerText;
                    txtCity.Text = node["City"].InnerText;
                    txtCountry.Text = node["Country"].InnerText;
                    txtMail.Text = node["E-mail"].InnerText;
                    
                }
                //Console.WriteLine((node["Username"].InnerText),Environment.NewLine);
                //Console.WriteLine((node["Password"].InnerText),Environment.NewLine);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            XmlDocument xdosya = new XmlDocument();
            xdosya.Load(@"veri.xml");

           

            foreach (XmlNode node in xdosya.DocumentElement)
            {
                if ((node["Password"].InnerText) == sha256_hash(txtSifre.Text))
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
               
                //Console.WriteLine((node["Username"].InnerText),Environment.NewLine);
                //Console.WriteLine((node["Password"].InnerText),Environment.NewLine);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //XDocument xDelete = XDocument.Load(@"veri.xml");
            //xDelete.Root.Elements().Where(x => x.Element("Username").Value == dgwUsers.CurrentRow.Cells[0].Value.ToString()).Remove();
            //xDelete.Save(@"veri.xml");
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

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }
    }

}
