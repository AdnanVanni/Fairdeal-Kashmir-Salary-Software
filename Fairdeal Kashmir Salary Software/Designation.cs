using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Fairdeal_Kashmir_Salary_Software
{
    public partial class Designation : MetroFramework.Forms.MetroForm
    {
        public Designation()
        {
            InitializeComponent();
        }

        private void Designation_Load(object sender, EventArgs e)
        {

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            label2.Visible = false;
            label3.Text = "Enter Designation eg.Security Gaurd";
            label3.ForeColor = System.Drawing.Color.Red;
            fillGrid();
            dataGridViewDesg.Rows[0].Selected = false;
            btnDelete.Visible = false;

        }
        private void fillGrid()
        {
            try
            {
                SqlCommand cmdd = new SqlCommand();
                cmdd.CommandText = "SELECT * FROM Designations";
                SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(cmdd.CommandText, DataManager.connectionString);
                connection1.Open();
                DataSet ds1 = new DataSet();
                dataadapter.Fill(ds1, "Designations");
                connection1.Close();
                dataGridViewDesg.DataSource = ds1;
                dataGridViewDesg.DataMember = "Designations";
                dataGridViewDesg.Columns[0].HeaderText = "Designations List";
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }





        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdd = new SqlCommand();
                cmdd.CommandText = "delete from Designations where Designation=@DesignationName";
                cmdd.Parameters.AddWithValue("@DesignationName", label2.Text);
                DataManager.executeNonQuery(cmdd);
                MessageBox.Show("Delete successful");
                Designation dep = new Designation();
                dep.Show();
                this.Hide();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        { try
            {
                if (txtDName.Text == "")
                { MessageBox.Show("Enter name of designation"); return; }

                SqlCommand cmdd = new SqlCommand();
                if (btnAdd.Text == "Add")
                {
                    cmdd.CommandText = "insert into designations values (@DesignationName)";
                }
                if (btnAdd.Text == "Update")
                {
                    cmdd.CommandText = "Update Designations set Designation=@DesignationName where Designation=@DN";

                }
                cmdd.Parameters.AddWithValue("@DesignationName", txtDName.Text);
                cmdd.Parameters.AddWithValue("@DN", label2.Text);
                DataManager.executeNonQuery(cmdd);
                MessageBox.Show("Saved");
                Designation dep = new Designation();
                dep.Show();
                this.Hide();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dataGridViewDesg_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Visible = true;

            foreach (DataGridViewRow row in dataGridViewDesg.SelectedRows)
            {
                btnAdd.Text = "Update";
                btnDelete.Visible = true;

                label3.Text = "*Please note that you are updating " + row.Cells[0].Value.ToString() + "'s details";
                label3.ForeColor = System.Drawing.Color.Red;
                txtDName.Text = row.Cells[0].Value.ToString();
                label2.Text = row.Cells[0].Value.ToString();


            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}




