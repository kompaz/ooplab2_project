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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        //private void AdminPage_Load(object sender, EventArgs e)
        //{
        //    KayitGetir();
        //}

        private void AdminPage_Load(object sender, EventArgs e)
        {
            LoadorRefreshPage();
        }

        public void LoadorRefreshPage()
        {

            SqlCommand commandList = new SqlCommand("Select userName,namesurname,phoneNumber,address,city,country,email from userTable", sqlOperations.cnn);

            sqlOperations.CheckConnection(sqlOperations.cnn);

            SqlDataAdapter da = new SqlDataAdapter(commandList);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgwUsers.DataSource = dt;

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            SqlCommand commdanAdd = new SqlCommand("Insert into userTable (userName,userPassword,namesurname,phoneNumber,address,city,country,email) values(@pusername,@ppassword,@pnamesurname,@pphoneNumber,@paddress,@pcity,@pcountry,@pmail)", sqlOperations.cnn);

            sqlOperations.CheckConnection(sqlOperations.cnn);

            commdanAdd.Parameters.AddWithValue("@pusername", txtUsername.Text);
            commdanAdd.Parameters.AddWithValue("@ppassword", sha256_hash(txtPassword.Text));
            commdanAdd.Parameters.AddWithValue("@pnamesurname", txtNameSurname.Text);
            commdanAdd.Parameters.AddWithValue("@pphoneNumber", txtPhone.Text);
            commdanAdd.Parameters.AddWithValue("@paddress", txtAddress.Text);
            commdanAdd.Parameters.AddWithValue("@pcity", txtCity.Text);
            commdanAdd.Parameters.AddWithValue("@pcountry", txtCountry.Text);
            commdanAdd.Parameters.AddWithValue("@pmail", txtMail.Text);

            commdanAdd.ExecuteNonQuery();

            LoadorRefreshPage();
        }

        string selecteduserName;

        private void dgwUsers_SelectionChanged(object sender, EventArgs e)
        {          
             selecteduserName = (dgwUsers.CurrentRow.Cells["userName"].Value).ToString();
             txtUsername.Text = (dgwUsers.CurrentRow.Cells["userName"].Value).ToString();
             txtNameSurname.Text = (dgwUsers.CurrentRow.Cells["namesurname"].Value).ToString();
             txtPhone.Text = (dgwUsers.CurrentRow.Cells["phonenumber"].Value).ToString();
             txtAddress.Text = (dgwUsers.CurrentRow.Cells["address"].Value).ToString();
             txtCity.Text = (dgwUsers.CurrentRow.Cells["city"].Value).ToString();
             txtCountry.Text = (dgwUsers.CurrentRow.Cells["country"].Value).ToString();
             txtMail.Text = (dgwUsers.CurrentRow.Cells["email"].Value).ToString();
            
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            SqlCommand commanDelete = new SqlCommand("Delete from userTable where userName=@puserName", sqlOperations.cnn);

            sqlOperations.CheckConnection(sqlOperations.cnn);

            commanDelete.Parameters.AddWithValue("@puserName", selecteduserName);

            commanDelete.ExecuteNonQuery();

            LoadorRefreshPage();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commanupdate = new SqlCommand("Update userTable set userName=@puserName , userPassword=@ppassword , namesurname= @pnamesurname , phoneNumber= @pphoneNumber, address= @paddress , city =@pcity, country = @pcountry, email = @pmail where username= @puserName",sqlOperations.cnn);

            sqlOperations.CheckConnection(sqlOperations.cnn);

            commanupdate.Parameters.AddWithValue("@puserName", txtUsername.Text);
            commanupdate.Parameters.AddWithValue("@ppassword", txtPassword.Text);
            commanupdate.Parameters.AddWithValue("@pnamesurname", txtNameSurname.Text);
            commanupdate.Parameters.AddWithValue("@pphoneNumber", txtPhone.Text);
            commanupdate.Parameters.AddWithValue("@paddress", txtAddress.Text);
            commanupdate.Parameters.AddWithValue("@pcity", txtCity.Text);
            commanupdate.Parameters.AddWithValue("@pcountry", txtCountry.Text);
            commanupdate.Parameters.AddWithValue("@pmail", txtMail.Text);

            commanupdate.ExecuteNonQuery();

            LoadorRefreshPage();

        }

        private void btnListed_Click(object sender, EventArgs e)
        {
            LoadorRefreshPage();
        }

        //private void KayitGetir()
        //{
        //    //DataSet dset = new DataSet();
        //    //XmlReader dataReader = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
        //    //dset.ReadXml(dataReader);
        //    //dgwUsers.DataSource = dset.Tables[0];
        //    //dgwUsers.Columns["Password"].Visible = false;
        //    //dataReader.Close();
        //}

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    //XDocument xUpdate = XDocument.Load(@"veri.xml");
        //    //XElement elementUpdate = xUpdate.Element("Users").Elements("User").FirstOrDefault(x => x.Element("Username").Value == txtUsername.Text);
        //    //if (elementUpdate != null)
        //    //{
        //    //    elementUpdate.SetElementValue("Password", sha256_hash(txtPassword.Text));
        //    //    elementUpdate.SetElementValue("Name-Surname", txtNameSurname.Text);
        //    //    elementUpdate.SetElementValue("Phone-Number", txtPhone.Text);
        //    //    elementUpdate.SetElementValue("Address", txtAddress.Text);
        //    //    elementUpdate.SetElementValue("City", txtCity.Text);
        //    //    elementUpdate.SetElementValue("Country", txtCountry.Text);
        //    //    elementUpdate.SetElementValue("E-mail", txtMail.Text);
        //    //    xUpdate.Save(@"veri.xml");
        //    //    KayitGetir();
        //    //}
        //}

        //private void btnAddUser_Click(object sender, EventArgs e)
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
        //    KayitGetir();
        //}



        //private void btnDeleteUser_Click(object sender, EventArgs e)
        //{
        //    //XDocument xDelete = XDocument.Load(@"veri.xml");
        //    //xDelete.Root.Elements().Where(x => x.Element("Username").Value == dgwUsers.CurrentRow.Cells[0].Value.ToString()).Remove();
        //    //xDelete.Save(@"veri.xml");
        //    //MessageBox.Show("kayit silindi.");
        //    //KayitGetir();
        //}



        private void dgwUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtUsername.Text = dgwUsers.CurrentRow.Cells[0].Value.ToString();
            //txtPassword.Text = dgwUsers.CurrentRow.Cells[1].Value.ToString();
            //txtNameSurname.Text = dgwUsers.CurrentRow.Cells[2].Value.ToString();
            //txtPhone.Text = dgwUsers.CurrentRow.Cells[3].Value.ToString();
            //txtAddress.Text = dgwUsers.CurrentRow.Cells[4].Value.ToString();
            //txtCity.Text = dgwUsers.CurrentRow.Cells[5].Value.ToString();
            //txtCountry.Text = dgwUsers.CurrentRow.Cells[6].Value.ToString();
            //txtMail.Text = dgwUsers.CurrentRow.Cells[7].Value.ToString();
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

        private void dgwUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
    }
}
