
namespace ooplab
{
    partial class settingsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rBtnEasy = new System.Windows.Forms.RadioButton();
            this.rBtnNormal = new System.Windows.Forms.RadioButton();
            this.rBtnHard = new System.Windows.Forms.RadioButton();
            this.rBtnCustom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txBx_Mtrx2 = new System.Windows.Forms.TextBox();
            this.txBx_Mtrx1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chckbox1 = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.chckbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Location = new System.Drawing.Point(15, 26);
            this.rBtnEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(48, 19);
            this.rBtnEasy.TabIndex = 0;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            this.rBtnEasy.CheckedChanged += new System.EventHandler(this.rBtnEasy_CheckedChanged);
            // 
            // rBtnNormal
            // 
            this.rBtnNormal.AutoSize = true;
            this.rBtnNormal.Location = new System.Drawing.Point(15, 57);
            this.rBtnNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtnNormal.Name = "rBtnNormal";
            this.rBtnNormal.Size = new System.Drawing.Size(65, 19);
            this.rBtnNormal.TabIndex = 4;
            this.rBtnNormal.TabStop = true;
            this.rBtnNormal.Text = "Normal";
            this.rBtnNormal.UseVisualStyleBackColor = true;
            this.rBtnNormal.CheckedChanged += new System.EventHandler(this.rBtnNormal_CheckedChanged);
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.Location = new System.Drawing.Point(15, 87);
            this.rBtnHard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(51, 19);
            this.rBtnHard.TabIndex = 5;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            this.rBtnHard.CheckedChanged += new System.EventHandler(this.rBtnHard_CheckedChanged);
            // 
            // rBtnCustom
            // 
            this.rBtnCustom.AutoSize = true;
            this.rBtnCustom.Location = new System.Drawing.Point(134, 26);
            this.rBtnCustom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rBtnCustom.Name = "rBtnCustom";
            this.rBtnCustom.Size = new System.Drawing.Size(67, 19);
            this.rBtnCustom.TabIndex = 1;
            this.rBtnCustom.TabStop = true;
            this.rBtnCustom.Text = "Custom";
            this.rBtnCustom.UseVisualStyleBackColor = true;
            this.rBtnCustom.CheckedChanged += new System.EventHandler(this.rBtnCustom_CheckedChanged);
            this.rBtnCustom.Enter += new System.EventHandler(this.rBtnCustom_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txBx_Mtrx2);
            this.groupBox1.Controls.Add(this.txBx_Mtrx1);
            this.groupBox1.Controls.Add(this.rBtnEasy);
            this.groupBox1.Controls.Add(this.rBtnCustom);
            this.groupBox1.Controls.Add(this.rBtnNormal);
            this.groupBox1.Controls.Add(this.rBtnHard);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(239, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty Options";
            // 
            // txBx_Mtrx2
            // 
            this.txBx_Mtrx2.Location = new System.Drawing.Point(178, 50);
            this.txBx_Mtrx2.Name = "txBx_Mtrx2";
            this.txBx_Mtrx2.Size = new System.Drawing.Size(23, 23);
            this.txBx_Mtrx2.TabIndex = 3;
            this.txBx_Mtrx2.TextChanged += new System.EventHandler(this.txBx_Mtrx2_TextChanged);
            this.txBx_Mtrx2.VisibleChanged += new System.EventHandler(this.rBtnCustom_CheckedChanged);
            // 
            // txBx_Mtrx1
            // 
            this.txBx_Mtrx1.Location = new System.Drawing.Point(147, 50);
            this.txBx_Mtrx1.Name = "txBx_Mtrx1";
            this.txBx_Mtrx1.Size = new System.Drawing.Size(25, 23);
            this.txBx_Mtrx1.TabIndex = 2;
            this.txBx_Mtrx1.TextChanged += new System.EventHandler(this.txBx_Mtrx1_TextChanged);
            this.txBx_Mtrx1.VisibleChanged += new System.EventHandler(this.rBtnCustom_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(18, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(239, 138);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape Option";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 101);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Round";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Triangle";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Square";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(430, 266);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chckbox1
            // 
            this.chckbox1.Controls.Add(this.checkBox6);
            this.chckbox1.Controls.Add(this.checkBox5);
            this.chckbox1.Controls.Add(this.checkBox4);
            this.chckbox1.Location = new System.Drawing.Point(340, 18);
            this.chckbox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chckbox1.Name = "chckbox1";
            this.chckbox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chckbox1.Size = new System.Drawing.Size(219, 112);
            this.chckbox1.TabIndex = 3;
            this.chckbox1.TabStop = false;
            this.chckbox1.Text = "Colour";
            this.chckbox1.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(10, 87);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(60, 19);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "Purple";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(10, 57);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(57, 19);
            this.checkBox5.TabIndex = 1;
            this.checkBox5.Text = "Green";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(10, 27);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(49, 19);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Blue";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // settingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.chckbox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "settingsPage";
            this.Text = "settingsPage";
            this.Load += new System.EventHandler(this.settingsPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.chckbox1.ResumeLayout(false);
            this.chckbox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnEasy;
        private System.Windows.Forms.RadioButton rBtnNormal;
        private System.Windows.Forms.RadioButton rBtnHard;
        private System.Windows.Forms.RadioButton rBtnCustom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txBx_Mtrx2;
        private System.Windows.Forms.TextBox txBx_Mtrx1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox chckbox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}