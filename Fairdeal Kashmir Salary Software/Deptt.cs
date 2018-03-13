using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fairdeal_Kashmir_Salary_Software
{
    public partial class Deptt : MetroFramework.Forms.MetroForm
    {
        public Deptt()
        {
            InitializeComponent();
        }

        private void Deptt_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            label2.Visible = false;
            label3.Text = "Enter department name as department(location) eg.I.T(Parimpora)";
            label3.ForeColor = System.Drawing.Color.Red;
            fillGrid();
            dataGridViewDeptt.Rows[0].Selected = false;
           // btnDelete.Visible = false;
            
        }
        private void fillGrid()
        {
            try
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
                dataGridViewDeptt.Columns[0].HeaderText = "Department Name/Location";
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dataGridViewDeptt_SelectionChanged(object sender, EventArgs e)
        {
          //  btnDelete.Visible = true;
            
            foreach (DataGridViewRow row in dataGridViewDeptt.SelectedRows)
            {
               // btnAdd.Text = "Update";
              //  btnDelete.Visible = true;

               // label3.Text = "*Please note that you are updating " + row.Cells[0].Value.ToString() + "'s details";
                label3.ForeColor = System.Drawing.Color.Red;
                txtDName.Text = row.Cells[0].Value.ToString();
                label2.Text= row.Cells[0].Value.ToString();



            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdd = new SqlCommand();


                cmdd.CommandText = "delete from Departments where departmentName=@DepartmentName";
                cmdd.Parameters.AddWithValue("@DepartmentName", label2.Text);

                DataManager.executeNonQuery(cmdd);
                MessageBox.Show("Delete successful");
                Deptt dep = new Deptt();
                dep.Show();
                this.Hide();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdd = new SqlCommand();
                if (btnAdd.Text == "Add")
                {
                    cmdd.CommandText = "insert into departments values (@DepartmentName)";
                }
                //if (btnAdd.Text == "Update")
                //{
                //    cmdd.CommandText = "Update Departments set DepartmentName=@DepartmentName where departmentName=@DN";

                //}
                cmdd.Parameters.AddWithValue("@DepartmentName", txtDName.Text);
                cmdd.Parameters.AddWithValue("@DN", label2.Text);
                DataManager.executeNonQuery(cmdd);
                MessageBox.Show("Saved");
                Deptt dep = new Deptt();
                dep.Show();
                this.Hide();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp E = new Emp();
            E.Show();
            this.Hide();
        }
    }
}
