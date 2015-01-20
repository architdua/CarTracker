using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTracker
{
    public partial class ConnectionString : Form
    {
        public ConnectionString()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConnectionString.Text != String.Empty)
                {
                    StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory +
                    "\\ConnectionString.txt", false);
                    sw.Write(txtConnectionString.Text);
                    sw.Close();
                    MessageBox.Show("Updated Connection String");
                }
                else
                {
                    MessageBox.Show("Please enter a value for the connection");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

    }
}
