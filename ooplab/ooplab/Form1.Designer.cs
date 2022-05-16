
namespace ooplab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cB_showPassword = new System.Windows.Forms.CheckBox();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btnAboutGame = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(345, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(113, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(345, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cB_showPassword
            // 
            this.cB_showPassword.AutoSize = true;
            this.cB_showPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cB_showPassword.Location = new System.Drawing.Point(345, 180);
            this.cB_showPassword.Name = "cB_showPassword";
            this.cB_showPassword.Size = new System.Drawing.Size(127, 23);
            this.cB_showPassword.TabIndex = 4;
            this.cB_showPassword.Text = "Show Password";
            this.cB_showPassword.UseVisualStyleBackColor = true;
            this.cB_showPassword.CheckedChanged += new System.EventHandler(this.cB_showPassword_CheckedChanged);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SignUp.Location = new System.Drawing.Point(110, 235);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(88, 31);
            this.btn_SignUp.TabIndex = 5;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // btnAboutGame
            // 
            this.btnAboutGame.Location = new System.Drawing.Point(548, 374);
            this.btnAboutGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAboutGame.Name = "btnAboutGame";
            this.btnAboutGame.Size = new System.Drawing.Size(112, 22);
            this.btnAboutGame.TabIndex = 6;
            this.btnAboutGame.Text = "About Game";
            this.btnAboutGame.UseVisualStyleBackColor = true;
            this.btnAboutGame.Click += new System.EventHandler(this.btnAboutGame_Click_1);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(454, 373);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(75, 23);
            this.btn_Help.TabIndex = 7;
            this.btn_Help.Text = "HELP";
            this.btn_Help.UseVisualStyleBackColor = true;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(670, 405);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btnAboutGame);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.cB_showPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cB_showPassword;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btnAboutGame;
        private System.Windows.Forms.Button btn_Help;
    }
}

