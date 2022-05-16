
namespace ooplab
{
    partial class helpPage
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
            this.lbl_usage = new System.Windows.Forms.Label();
            this.btn_aboutGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_usage
            // 
            this.lbl_usage.AutoSize = true;
            this.lbl_usage.Location = new System.Drawing.Point(29, 35);
            this.lbl_usage.Name = "lbl_usage";
            this.lbl_usage.Size = new System.Drawing.Size(660, 15);
            this.lbl_usage.TabIndex = 0;
            this.lbl_usage.Text = "This game u must play with mouse. U must select one box and move it after that th" +
    "e game pop-out three more random box";
            // 
            // btn_aboutGame
            // 
            this.btn_aboutGame.Location = new System.Drawing.Point(29, 115);
            this.btn_aboutGame.Name = "btn_aboutGame";
            this.btn_aboutGame.Size = new System.Drawing.Size(75, 23);
            this.btn_aboutGame.TabIndex = 1;
            this.btn_aboutGame.Text = "credits";
            this.btn_aboutGame.UseVisualStyleBackColor = true;
            this.btn_aboutGame.Click += new System.EventHandler(this.btn_aboutGame_Click);
            // 
            // helpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_aboutGame);
            this.Controls.Add(this.lbl_usage);
            this.Name = "helpPage";
            this.Text = "helpPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usage;
        private System.Windows.Forms.Button btn_aboutGame;
    }
}