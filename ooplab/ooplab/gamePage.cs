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
        bool onClick = true;
        Color clr;
        Button tempBtn;

        private int col = 0, row = 0;
        private List<string> Shape = new List<string>();
        private List<Color> Colour = new List<Color>();

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //btn.BackColor = Color.Black;
            if (onClick && btn.BackColor != Color.LightBlue)
            {
                onClick = false;
                clr = btn.BackColor;
                tempBtn = btn;
            }
            else if (!onClick && btn.BackColor == Color.LightBlue)
            {
                int counter = 0;

                onClick = true;
                btn.BackColor = clr;
                tempBtn.BackColor = Color.LightBlue;
                btn.Text = tempBtn.Text;
                tempBtn.Text = "";
                Random randomName = new Random();
                for (int i = 0; i < 3; i++)
                {
                    int a = randomName.Next(0, row);
                    int b = randomName.Next(0, col);
                    if (MyButtons[a, b].BackColor != Color.LightBlue)
                    {
                        i--;
                        continue;
                    }

                    int index = randomName.Next(0, Colour.Count);
                    MyButtons[a, b].BackColor = Colour[index];

                    index = randomName.Next(0, Shape.Count);
                    MyButtons[a, b].Text = Shape[index];
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (MyButtons[i, j].BackColor == Color.LightBlue)
                        {
                            counter++;
                        }
                    }
                }
                if (counter < 3)
                {
                    MessageBox.Show("GAME OVER!");
                }
            }

        }

        Button[,] MyButtons;

        private void gamePage_Load(object sender, EventArgs e)
        {


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

            this.Size = new Size(19 + row * 37, 19 + col * 38);
            MyButtons = new Button[row, col];

            for (int i = 0; i < row; i++)
            {
                Random r = new Random();
                for (int j = 0; j < col; j++)
                {
                    Button btn = new Button();
                    btn.Location = new Point(5 + (i * 36), 5 + j * 36);
                    btn.Size = new Size(35, 35);
                    btn.BackColor = Color.LightBlue;
                    btn.Click += new EventHandler(button_Click);
                    MyButtons[i, j] = btn;
                    this.Controls.Add(btn);
                }
            }
            this.AutoSize = true;

            Random randomName = new Random(); //only required once


            if (Settings1.Default.data_blue)
            {
                Colour.Add(Color.Blue);
            }
            if (Settings1.Default.data_green)
            {
                Colour.Add(Color.Green);
            }
            if (Settings1.Default.data_purple)
            {
                Colour.Add(Color.Purple);
            }

            if (Settings1.Default.data_triangle)
            {
                Shape.Add("△");
            }
            if (Settings1.Default.data_square)
            {
                Shape.Add("☐");
            }
            if (Settings1.Default.data_round)
            {
                Shape.Add("◯");
            }

            for (int i = 0; i < 3; i++)
            {
                int a = randomName.Next(0, row);
                int b = randomName.Next(0, col);
                if (MyButtons[a, b].BackColor != Color.LightBlue)
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