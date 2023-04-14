namespace FCM
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.clubsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clubsToolStripMenuItem1,
            this.playersToolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(645, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // clubsToolStripMenuItem1
            // 
            this.clubsToolStripMenuItem1.Name = "clubsToolStripMenuItem1";
            this.clubsToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.clubsToolStripMenuItem1.Text = "Clubs";
            this.clubsToolStripMenuItem1.Click += new System.EventHandler(this.clubsToolStripMenuItem1_Click);
            // 
            // playersToolStripMenuItem1
            // 
            this.playersToolStripMenuItem1.Name = "playersToolStripMenuItem1";
            this.playersToolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.playersToolStripMenuItem1.Text = "Players";
            this.playersToolStripMenuItem1.Click += new System.EventHandler(this.playersToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 402);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem clubsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem1;
    }
}

