
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnEasy
            // 
            this.rBtnEasy.AutoSize = true;
            this.rBtnEasy.Location = new System.Drawing.Point(17, 35);
            this.rBtnEasy.Name = "rBtnEasy";
            this.rBtnEasy.Size = new System.Drawing.Size(59, 24);
            this.rBtnEasy.TabIndex = 0;
            this.rBtnEasy.TabStop = true;
            this.rBtnEasy.Text = "Easy";
            this.rBtnEasy.UseVisualStyleBackColor = true;
            this.rBtnEasy.CheckedChanged += new System.EventHandler(this.rBtnEasy_CheckedChanged);
            // 
            // rBtnNormal
            // 
            this.rBtnNormal.AutoSize = true;
            this.rBtnNormal.Location = new System.Drawing.Point(17, 76);
            this.rBtnNormal.Name = "rBtnNormal";
            this.rBtnNormal.Size = new System.Drawing.Size(80, 24);
            this.rBtnNormal.TabIndex = 4;
            this.rBtnNormal.TabStop = true;
            this.rBtnNormal.Text = "Normal";
            this.rBtnNormal.UseVisualStyleBackColor = true;
            this.rBtnNormal.CheckedChanged += new System.EventHandler(this.rBtnNormal_CheckedChanged);
            // 
            // rBtnHard
            // 
            this.rBtnHard.AutoSize = true;
            this.rBtnHard.Location = new System.Drawing.Point(17, 116);
            this.rBtnHard.Name = "rBtnHard";
            this.rBtnHard.Size = new System.Drawing.Size(63, 24);
            this.rBtnHard.TabIndex = 5;
            this.rBtnHard.TabStop = true;
            this.rBtnHard.Text = "Hard";
            this.rBtnHard.UseVisualStyleBackColor = true;
            this.rBtnHard.CheckedChanged += new System.EventHandler(this.rBtnHard_CheckedChanged);
            // 
            // rBtnCustom
            // 
            this.rBtnCustom.AutoSize = true;
            this.rBtnCustom.Location = new System.Drawing.Point(153, 35);
            this.rBtnCustom.Name = "rBtnCustom";
            this.rBtnCustom.Size = new System.Drawing.Size(80, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty Options";
            // 
            // txBx_Mtrx2
            // 
            this.txBx_Mtrx2.Location = new System.Drawing.Point(203, 67);
            this.txBx_Mtrx2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_Mtrx2.Name = "txBx_Mtrx2";
            this.txBx_Mtrx2.Size = new System.Drawing.Size(26, 27);
            this.txBx_Mtrx2.TabIndex = 3;
            this.txBx_Mtrx2.TextChanged += new System.EventHandler(this.txBx_Mtrx2_TextChanged);
            this.txBx_Mtrx2.VisibleChanged += new System.EventHandler(this.rBtnCustom_CheckedChanged);
            // 
            // txBx_Mtrx1
            // 
            this.txBx_Mtrx1.Location = new System.Drawing.Point(168, 67);
            this.txBx_Mtrx1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txBx_Mtrx1.Name = "txBx_Mtrx1";
            this.txBx_Mtrx1.Size = new System.Drawing.Size(28, 27);
            this.txBx_Mtrx1.TabIndex = 2;
            this.txBx_Mtrx1.TextChanged += new System.EventHandler(this.txBx_Mtrx1_TextChanged);
            this.txBx_Mtrx1.VisibleChanged += new System.EventHandler(this.rBtnCustom_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(21, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 184);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape Option";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(17, 135);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(74, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Round";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 88);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(84, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Triangle";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 41);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(77, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Square";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(492, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // settingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "settingsPage";
            this.Text = "settingsPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}