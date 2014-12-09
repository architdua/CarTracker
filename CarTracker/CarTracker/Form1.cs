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
        

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void addCarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCar newCarForm = new AddCar();
            newCarForm.MdiParent = this; 
            newCarForm.Show();
            
        }

        private void carFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarFinder newSearchCar = new CarFinder();
            newSearchCar.MdiParent = this;
            newSearchCar.Show();
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Locations newLocations = new Locations();
            newLocations.MdiParent = this;
            newLocations.Show();
        }

        private void locationsDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database.frmDatabase newLocationDB = new Database.frmDatabase();
            newLocationDB.MdiParent = this;
            newLocationDB.Show();
        }
    }
}
