
namespace ooplab
{
    partial class gamePage
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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.Location = new System.Drawing.Point(0, 2);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(905, 592);
            this.pnlGame.TabIndex = 0;
            // 
            // gamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 596);
            this.Controls.Add(this.pnlGame);
            this.Name = "gamePage";
            this.Text = "gamePage";
            this.Load += new System.EventHandler(this.gamePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
    }
}