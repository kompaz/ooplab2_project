using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ooplab
{
    public partial class aboutGame : Form
    {
        public aboutGame()
        {
            InitializeComponent();
            txtAboutGame.Text = "Sinan Kompas ve Göknur Sevinç tarafından yapıldı.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAboutGame_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
