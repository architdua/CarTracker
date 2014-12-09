namespace CarTracker.Database
{
    partial class frmDatabase
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
            this.pnlTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmLocationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNOfParkingSpots = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnGetValues = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtParkingSpots = new System.Windows.Forms.TextBox();
            this.txtLocationCity = new System.Windows.Forms.TextBox();
            this.lblLocationCity = new System.Windows.Forms.Label();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.lblParkingSpots = new System.Windows.Forms.Label();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.lblLocationInfo = new System.Windows.Forms.Label();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.dataGridView1);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTable.Location = new System.Drawing.Point(236, 0);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTable.Size = new System.Drawing.Size(454, 369);
            this.pnlTable.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLocationID,
            this.clmLocationName,
            this.clmNOfParkingSpots,
            this.clmLocationCity});
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
            this.dataGridView1.Size = new System.Drawing.Size(434, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmLocationID
            // 
            this.clmLocationID.DataPropertyName = "Location ID";
            this.clmLocationID.HeaderText = "Location ID";
            this.clmLocationID.Name = "clmLocationID";
            this.clmLocationID.ReadOnly = true;
            // 
            // clmLocationName
            // 
            this.clmLocationName.DataPropertyName = "Location Name";
            this.clmLocationName.HeaderText = "Location Name";
            this.clmLocationName.Name = "clmLocationName";
            this.clmLocationName.ReadOnly = true;
            // 
            // clmNOfParkingSpots
            // 
            this.clmNOfParkingSpots.DataPropertyName = "Number of Parking Spots";
            this.clmNOfParkingSpots.HeaderText = "# of Parking Spots";
            this.clmNOfParkingSpots.Name = "clmNOfParkingSpots";
            this.clmNOfParkingSpots.ReadOnly = true;
            // 
            // clmLocationCity
            // 
            this.clmLocationCity.DataPropertyName = "Location City";
            this.clmLocationCity.HeaderText = "Location City";
            this.clmLocationCity.Name = "clmLocationCity";
            this.clmLocationCity.ReadOnly = true;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnGetValues);
            this.pnlInfo.Controls.Add(this.btnDelete);
            this.pnlInfo.Controls.Add(this.btnUpdate);
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
            this.pnlInfo.Size = new System.Drawing.Size(236, 369);
            this.pnlInfo.TabIndex = 2;
            // 
            // btnGetValues
            // 
            this.btnGetValues.Location = new System.Drawing.Point(125, 265);
            this.btnGetValues.Name = "btnGetValues";
            this.btnGetValues.Size = new System.Drawing.Size(75, 23);
            this.btnGetValues.TabIndex = 7;
            this.btnGetValues.Text = "Get Values";
            this.btnGetValues.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(28, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 221);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(28, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
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
            this.txtLocationCity.TabIndex = 2;
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
            // frmDatabase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(690, 369);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.pnlInfo);
            this.Name = "frmDatabase";
            this.Text = "Locations Database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNOfParkingSpots;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocationCity;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnGetValues;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtParkingSpots;
        private System.Windows.Forms.TextBox txtLocationCity;
        private System.Windows.Forms.Label lblLocationCity;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Label lblParkingSpots;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Label lblLocationInfo;
    }
}