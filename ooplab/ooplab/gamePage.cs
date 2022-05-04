using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ooplab
{
    public partial class gamePage : Form
    {
        public gamePage()
        {
            InitializeComponent();
        }
        int n;
        PictureBox[,] P;
       
        private void gamePage_Load(object sender, EventArgs e)
        {
            n = 9;
            P = new PictureBox[n,n];
            int left = 2, top = 2;
            
            for(int i=0; i<n; i++)
            {
                left = 2;
                Random r = new Random();
                for (int j = 0; j < n; j++)
                {
                   
                    P[i, j] = new PictureBox();
                    P[i, j].BackColor = Color.FromArgb(255, r.Next(0, 256), r.Next(0, 256));
                    P[i, j].Location = new Point(left, top);
                    P[i, j].Size = new Size(60, 60);
                    left += 60;
                    pnlGame.Controls.Add(P[i, j]);

                }
                top += 60;
            }


        }
    }
}
