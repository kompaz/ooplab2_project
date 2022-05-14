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

        Button[,] MyButtons;
       
        private void gamePage_Load(object sender, EventArgs e)
        {
            int col = 0, row= 0;

            if (Settings1.Default.user_data == "rBtnEasy")
            {
                col = 15;
                row = 15;               
            }
            else if (Settings1.Default.user_data == "rBtnNormal")
            {
                col = 9;
                row = 9;
            }
            else if (Settings1.Default.user_data == "rBtnHard")
            {
                col = 6;
                row = 6;
            }
            else if (Settings1.Default.user_data == "rBtnCustom")
            {               
                col = Settings1.Default.data_custom_row;
                row = Settings1.Default.data_custom_clmn;
            }

            this.Size = new Size(19+row*37, 19+col*38); 
            MyButtons = new Button[row, col];

            for (int i = 0; i < row; i++)
            {
                Random r = new Random();
                for (int j = 0; j < col; j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(5+(i*36),5+j*36);
                    btn.Size = new Size(35, 35);
                    btn.BackColor = Color.Gray;
                    MyButtons[i, j] = btn;
                    this.Controls.Add(btn);
                    
                }
               
            }
            this.AutoSize = true;

            Random randomName = new Random(); //only required once

            List<Color> Colour = new List<Color>();
            if (Settings1.Default.data_blue)
            {
                Colour.Add(Color.DeepSkyBlue);
            }
            if (Settings1.Default.data_green)
            {
                Colour.Add(Color.LightSeaGreen);
            }
            if (Settings1.Default.data_purple)
            {
                Colour.Add(Color.Purple);
            }

            List<string> Shape = new List<string>();
            if(Settings1.Default.data_triangle)
            {
                Shape.Add("△");
            }
            if(Settings1.Default.data_square)
            {
                Shape.Add("☐");
            }
            if(Settings1.Default.data_round)
            {
                Shape.Add("◯");
            }

            for (int i = 0; i < 3; i++)
            {
                int a = randomName.Next(0, row);
                int b = randomName.Next(0, col);
                if(MyButtons[a,b].BackColor != Color.LightBlue)
                {
                    i--;
                    continue;
                }

                int index = randomName.Next(0, Colour.Count);
                MyButtons[a, b].BackColor = Colour[index];

                index = randomName.Next(0, Shape.Count);
                MyButtons[a, b].Text = Shape[index];
            }

        }
    }
}
