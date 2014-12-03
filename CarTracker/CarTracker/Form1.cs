using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTracker
{
    public partial class frmMainForm : Form
    {
        AddCar newCarForm = new AddCar();
        CarFinder newSearchCar = new CarFinder();

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newCarForm.Show();
            newCarForm.MdiParent = this; 
        }

        private void searchCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newSearchCar.Show();
            newSearchCar.MdiParent = this;
        }
    }
}
