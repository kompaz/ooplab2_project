
namespace ooplab
{
    partial class aboutGame
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
            this.txtAboutGame = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAboutGame
            // 
            this.txtAboutGame.Location = new System.Drawing.Point(12, 30);
            this.txtAboutGame.Name = "txtAboutGame";
            this.txtAboutGame.Size = new System.Drawing.Size(615, 27);
            this.txtAboutGame.TabIndex = 0;
            this.txtAboutGame.TextChanged += new System.EventHandler(this.txtAboutGame_TextChanged);
            // 
            // aboutGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAboutGame);
            this.Name = "aboutGame";
            this.Text = "aboutGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAboutGame;
    }
}