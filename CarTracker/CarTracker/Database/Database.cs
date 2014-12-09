using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarTracker.Database
{
    public partial class frmDatabase : Form
    {
        public frmDatabase()
        {
            InitializeComponent();
        }
        string connectionString = "Server=ARCHIT;Database=Sample;Trusted_Connection=True";
        private void getDataFromDB()
        {
            SqlConnection sqlConn = null;
            try
            {
                sqlConn = new SqlConnection();
                sqlConn.ConnectionString = connectionString;

                //Open SQL Connection
                sqlConn.Open();

                string stringCommand = "SELECT * FROM LOCATIONS";

                //Insert Values into Dataset (a stack of tables)

                DataSet locationsDS = new DataSet();
                SqlDataAdapter sqlDA = new SqlDataAdapter(stringCommand, sqlConn);
                sqlDA.Fill(locationsDS);

                //Assign datasource to data grid view
                dataGridView1.DataSource = locationsDS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
            }

        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            // refresh Data from DB
            getDataFromDB();
        }
    }
}
