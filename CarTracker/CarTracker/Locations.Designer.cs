namespace CarTracker
{
    partial class Locations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtParkingSpots = new System.Windows.Forms.TextBox();
            this.txtLocationCity = new System.Windows.Forms.TextBox();
            this.lblLocationCity = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.lblParkingSpots = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblLocationInfo = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmLocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNOfParkingSpots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnSubmit);
            this.pnlInfo.Controls.Add(this.txtParkingSpots);
            this.pnlInfo.Controls.Add(this.txtLocationCity);
            this.pnlInfo.Controls.Add(this.lblLocationCity);
            this.pnlInfo.Controls.Add(this.txtLocationName);
            this.pnlInfo.Controls.Add(this.lblParkingSpots);
            this.pnlInfo.Controls.Add(this.lblLocationName);
            this.pnlInfo.Controls.Add(this.lblLocationInfo);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(236, 373);
            this.pnlInfo.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(149, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtParkingSpots
            // 
            this.txtParkingSpots.Location = new System.Drawing.Point(12, 114);
            this.txtParkingSpots.Name = "txtParkingSpots";
            this.txtParkingSpots.Size = new System.Drawing.Size(212, 20);
            this.txtParkingSpots.TabIndex = 1;
            // 
            // txtLocationCity
            // 
            this.txtLocationCity.Location = new System.Drawing.Point(12, 177);
            this.txtLocationCity.Name = "txtLocationCity";
            this.txtLocationCity.Size = new System.Drawing.Size(212, 20);
            this.txtLocationCity.TabIndex = 3;
            // 
            // lblLocationCity
            // 
            this.lblLocationCity.AutoSize = true;
            this.lblLocationCity.Location = new System.Drawing.Point(12, 150);
            this.lblLocationCity.Name = "lblLocationCity";
            this.lblLocationCity.Size = new System.Drawing.Size(117, 13);
            this.lblLocationCity.TabIndex = 0;
            this.lblLocationCity.Text = "Enter the Location City:";
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(12, 49);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(212, 20);
            this.txtLocationName.TabIndex = 0;
            // 
            // lblParkingSpots
            // 
            this.lblParkingSpots.AutoSize = true;
            this.lblParkingSpots.Location = new System.Drawing.Point(12, 88);
            this.lblParkingSpots.Name = "lblParkingSpots";
            this.lblParkingSpots.Size = new System.Drawing.Size(174, 13);
            this.lblParkingSpots.TabIndex = 0;
            this.lblParkingSpots.Text = "Enter the Number of Parking Spots:\r\n";
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(12, 33);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(128, 13);
            this.lblLocationName.TabIndex = 0;
            this.lblLocationName.Text = "Enter the Location Name:";
            // 
            // lblLocationInfo
            // 
            this.lblLocationInfo.AutoSize = true;
            this.lblLocationInfo.Location = new System.Drawing.Point(12, 9);
            this.lblLocationInfo.Name = "lblLocationInfo";
            this.lblLocationInfo.Size = new System.Drawing.Size(106, 13);
            this.lblLocationInfo.TabIndex = 0;
            this.lblLocationInfo.Text = "Location Information:";
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.dataGridView1);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTable.Location = new System.Drawing.Point(236, 0);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTable.Size = new System.Drawing.Size(359, 373);
            this.pnlTable.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLocationID,
            this.clmLocationCity,
            this.clmNOfParkingSpots,
            this.clmLocationName});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(339, 353);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmLocationID
            // 
            this.clmLocationID.DataPropertyName = "Location ID";
            this.clmLocationID.HeaderText = "Location ID";
            this.clmLocationID.Name = "clmLocationID";
            this.clmLocationID.ReadOnly = true;
            // 
            // clmLocationCity
            // 
            this.clmLocationCity.DataPropertyName = "Location City";
            this.clmLocationCity.HeaderText = "Location City";
            this.clmLocationCity.Name = "clmLocationCity";
            this.clmLocationCity.ReadOnly = true;
            // 
            // clmNOfParkingSpots
            // 
            this.clmNOfParkingSpots.DataPropertyName = "Number of Parking Spots";
            this.clmNOfParkingSpots.HeaderText = "# of Parking Spots";
            this.clmNOfParkingSpots.Name = "clmNOfParkingSpots";
            this.clmNOfParkingSpots.ReadOnly = true;
            // 
            // clmLocationName
            // 
            this.clmLocationName.DataPropertyName = "Location Name";
            this.clmLocationName.HeaderText = "Location Name";
            this.clmLocationName.Name = "clmLocationName";
            this.clmLocationName.ReadOnly = true;
            // 
            // Locations
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(595, 373);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlInfo);
            this.Name = "Locations";
            this.Text = "Locations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Locations_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label lblLocationInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtParkingSpots;
        private System.Windows.Forms.TextBox txtLocationCity;
        private System.Windows.Forms.Label lblLocationCity;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Label lblParkingSpots;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNOfParkingSpots;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationName;
    }
}