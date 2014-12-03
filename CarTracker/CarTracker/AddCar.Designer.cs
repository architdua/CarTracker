namespace CarTracker
{
    partial class AddCar
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblVehicleNumber = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.txtVehicleNumber = new System.Windows.Forms.TextBox();
            this.txtManufacturingYear = new System.Windows.Forms.TextBox();
            this.txtCarManufacturer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter the Car Model:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(13, 38);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(141, 13);
            this.lblManufacturer.TabIndex = 1;
            this.lblManufacturer.Text = "Enter the Car Manufacturer: ";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(13, 66);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(149, 13);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Enter the Manufacturing Year:\r\n";
            // 
            // lblVehicleNumber
            // 
            this.lblVehicleNumber.AutoSize = true;
            this.lblVehicleNumber.Location = new System.Drawing.Point(13, 94);
            this.lblVehicleNumber.Name = "lblVehicleNumber";
            this.lblVehicleNumber.Size = new System.Drawing.Size(131, 13);
            this.lblVehicleNumber.TabIndex = 3;
            this.lblVehicleNumber.Text = "Enter the Vehicle Number:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 120);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(99, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Enter the Car Price:";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(172, 5);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(100, 20);
            this.txtCarModel.TabIndex = 0;
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(172, 113);
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.Size = new System.Drawing.Size(100, 20);
            this.txtCarPrice.TabIndex = 4;
            // 
            // txtVehicleNumber
            // 
            this.txtVehicleNumber.Location = new System.Drawing.Point(172, 87);
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleNumber.TabIndex = 3;
            // 
            // txtManufacturingYear
            // 
            this.txtManufacturingYear.Location = new System.Drawing.Point(172, 59);
            this.txtManufacturingYear.Name = "txtManufacturingYear";
            this.txtManufacturingYear.Size = new System.Drawing.Size(100, 20);
            this.txtManufacturingYear.TabIndex = 2;
            // 
            // txtCarManufacturer
            // 
            this.txtCarManufacturer.Location = new System.Drawing.Point(172, 31);
            this.txtCarManufacturer.Name = "txtCarManufacturer";
            this.txtCarManufacturer.Size = new System.Drawing.Size(100, 20);
            this.txtCarManufacturer.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(42, 171);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(155, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCarManufacturer);
            this.Controls.Add(this.txtManufacturingYear);
            this.Controls.Add(this.txtVehicleNumber);
            this.Controls.Add(this.txtCarPrice);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblVehicleNumber);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblName);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblVehicleNumber;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.TextBox txtVehicleNumber;
        private System.Windows.Forms.TextBox txtManufacturingYear;
        private System.Windows.Forms.TextBox txtCarManufacturer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }
}