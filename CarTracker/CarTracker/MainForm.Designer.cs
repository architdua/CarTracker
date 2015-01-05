namespace CarTracker
{
    partial class frmMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationsDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem1,
            this.carFinderToolStripMenuItem,
            this.locationsToolStripMenuItem,
            this.locationsDatabaseToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.addCarToolStripMenuItem.Text = "File";
            // 
            // addCarToolStripMenuItem1
            // 
            this.addCarToolStripMenuItem1.Name = "addCarToolStripMenuItem1";
            this.addCarToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.addCarToolStripMenuItem1.Text = "Add Car";
            this.addCarToolStripMenuItem1.Click += new System.EventHandler(this.addCarToolStripMenuItem1_Click);
            // 
            // carFinderToolStripMenuItem
            // 
            this.carFinderToolStripMenuItem.Name = "carFinderToolStripMenuItem";
            this.carFinderToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.carFinderToolStripMenuItem.Text = "Car Finder";
            this.carFinderToolStripMenuItem.Click += new System.EventHandler(this.carFinderToolStripMenuItem_Click);
            // 
            // locationsToolStripMenuItem
            // 
            this.locationsToolStripMenuItem.Name = "locationsToolStripMenuItem";
            this.locationsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.locationsToolStripMenuItem.Text = "Locations";
            this.locationsToolStripMenuItem.Click += new System.EventHandler(this.locationsToolStripMenuItem_Click);
            // 
            // locationsDatabaseToolStripMenuItem
            // 
            this.locationsDatabaseToolStripMenuItem.Name = "locationsDatabaseToolStripMenuItem";
            this.locationsDatabaseToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.locationsDatabaseToolStripMenuItem.Text = "Locations Database";
            this.locationsDatabaseToolStripMenuItem.Click += new System.EventHandler(this.locationsDatabaseToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainForm";
            this.Text = "Car Tracker";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem carFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationsDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    }
}

