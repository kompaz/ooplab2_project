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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            KayitGetir();
        }

        private void KayitGetir()
        {
            DataSet dset = new DataSet();
            XmlReader dataReader = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
            dset.ReadXml(dataReader);
            dgwUsers.DataSource = dset.Tables[0];
            dataReader.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

        }
    }
}
