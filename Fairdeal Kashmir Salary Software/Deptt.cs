using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fairdeal_Kashmir_Salary_Software
{
    public partial class Deptt : Form
    {
        public Deptt()
        {
            InitializeComponent();
        }

        private void Deptt_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            fillGrid();
        }
        private void fillGrid()
        {
            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "SELECT * FROM Departments";
            SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(cmdd.CommandText, DataManager.connectionString);
            connection1.Open();
            DataSet ds1 = new DataSet();
            dataadapter.Fill(ds1, "Departments");
            connection1.Close();
            dataGridViewDeptt.DataSource = ds1;
            dataGridViewDeptt.DataMember = "Departments";
        }
    }
}
