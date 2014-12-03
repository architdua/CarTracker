namespace CarTracker
{
    partial class CarFinder
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtDisplayCarManufacturer = new System.Windows.Forms.TextBox();
            this.txtDisplayManufacturingYear = new System.Windows.Forms.TextBox();
            this.txtRequestVehicleNumber = new System.Windows.Forms.TextBox();
            this.txtDisplayCarPrice = new System.Windows.Forms.TextBox();
            this.txtDisplayCarModel = new System.Windows.Forms.TextBox();
            this.lblDisplayPrice = new System.Windows.Forms.Label();
            this.lblRequestVehicleNumber = new System.Windows.Forms.Label();
            this.lblDisplayYear = new System.Windows.Forms.Label();
            this.lblDisplayManufacturer = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(196, 157);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Find Car";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // txtDisplayCarManufacturer
            // 
            this.txtDisplayCarManufacturer.Enabled = false;
            this.txtDisplayCarManufacturer.Location = new System.Drawing.Point(171, 63);
            this.txtDisplayCarManufacturer.Name = "txtDisplayCarManufacturer";
            this.txtDisplayCarManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayCarManufacturer.TabIndex = 21;
            // 
            // txtDisplayManufacturingYear
            // 
            this.txtDisplayManufacturingYear.Enabled = false;
            this.txtDisplayManufacturingYear.Location = new System.Drawing.Point(171, 91);
            this.txtDisplayManufacturingYear.Name = "txtDisplayManufacturingYear";
            this.txtDisplayManufacturingYear.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayManufacturingYear.TabIndex = 20;
            // 
            // txtRequestVehicleNumber
            // 
            this.txtRequestVehicleNumber.Location = new System.Drawing.Point(171, 11);
            this.txtRequestVehicleNumber.Name = "txtRequestVehicleNumber";
            this.txtRequestVehicleNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRequestVehicleNumber.TabIndex = 19;
            // 
            // txtDisplayCarPrice
            // 
            this.txtDisplayCarPrice.Enabled = false;
            this.txtDisplayCarPrice.Location = new System.Drawing.Point(171, 117);
            this.txtDisplayCarPrice.Name = "txtDisplayCarPrice";
            this.txtDisplayCarPrice.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayCarPrice.TabIndex = 18;
            // 
            // txtDisplayCarModel
            // 
            this.txtDisplayCarModel.Enabled = false;
            this.txtDisplayCarModel.Location = new System.Drawing.Point(171, 37);
            this.txtDisplayCarModel.Name = "txtDisplayCarModel";
            this.txtDisplayCarModel.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayCarModel.TabIndex = 17;
            // 
            // lblDisplayPrice
            // 
            this.lblDisplayPrice.AutoSize = true;
            this.lblDisplayPrice.Location = new System.Drawing.Point(12, 124);
            this.lblDisplayPrice.Name = "lblDisplayPrice";
            this.lblDisplayPrice.Size = new System.Drawing.Size(53, 13);
            this.lblDisplayPrice.TabIndex = 16;
            this.lblDisplayPrice.Text = "Car Price:";
            // 
            // lblRequestVehicleNumber
            // 
            this.lblRequestVehicleNumber.AutoSize = true;
            this.lblRequestVehicleNumber.Location = new System.Drawing.Point(12, 18);
            this.lblRequestVehicleNumber.Name = "lblRequestVehicleNumber";
            this.lblRequestVehicleNumber.Size = new System.Drawing.Size(131, 13);
            this.lblRequestVehicleNumber.TabIndex = 15;
            this.lblRequestVehicleNumber.Text = "Enter the Vehicle Number:";
            // 
            // lblDisplayYear
            // 
            this.lblDisplayYear.AutoSize = true;
            this.lblDisplayYear.Location = new System.Drawing.Point(12, 98);
            this.lblDisplayYear.Name = "lblDisplayYear";
            this.lblDisplayYear.Size = new System.Drawing.Size(103, 13);
            this.lblDisplayYear.TabIndex = 14;
            this.lblDisplayYear.Text = "Manufacturing Year:\r\n";
            // 
            // lblDisplayManufacturer
            // 
            this.lblDisplayManufacturer.AutoSize = true;
            this.lblDisplayManufacturer.Location = new System.Drawing.Point(12, 70);
            this.lblDisplayManufacturer.Name = "lblDisplayManufacturer";
            this.lblDisplayManufacturer.Size = new System.Drawing.Size(95, 13);
            this.lblDisplayManufacturer.TabIndex = 13;
            this.lblDisplayManufacturer.Text = "Car Manufacturer: ";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(12, 44);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(58, 13);
            this.lblDisplayName.TabIndex = 12;
            this.lblDisplayName.Text = "Car Model:";
            // 
            // CarFinder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtDisplayCarManufacturer);
            this.Controls.Add(this.txtDisplayManufacturingYear);
            this.Controls.Add(this.txtRequestVehicleNumber);
            this.Controls.Add(this.txtDisplayCarPrice);
            this.Controls.Add(this.txtDisplayCarModel);
            this.Controls.Add(this.lblDisplayPrice);
            this.Controls.Add(this.lblRequestVehicleNumber);
            this.Controls.Add(this.lblDisplayYear);
            this.Controls.Add(this.lblDisplayManufacturer);
            this.Controls.Add(this.lblDisplayName);
            this.Name = "CarFinder";
            this.Text = "CarFinder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtDisplayCarManufacturer;
        private System.Windows.Forms.TextBox txtDisplayManufacturingYear;
        private System.Windows.Forms.TextBox txtRequestVehicleNumber;
        private System.Windows.Forms.TextBox txtDisplayCarPrice;
        private System.Windows.Forms.TextBox txtDisplayCarModel;
        private System.Windows.Forms.Label lblDisplayPrice;
        private System.Windows.Forms.Label lblRequestVehicleNumber;
        private System.Windows.Forms.Label lblDisplayYear;
        private System.Windows.Forms.Label lblDisplayManufacturer;
        private System.Windows.Forms.Label lblDisplayName;
    }
}