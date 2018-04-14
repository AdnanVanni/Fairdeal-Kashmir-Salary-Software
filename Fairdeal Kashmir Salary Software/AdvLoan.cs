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

namespace Fairdeal_Kashmir_Salary_Software
{
    public partial class AdvLoan : MetroFramework.Forms.MetroForm
    {
        public AdvLoan()
        {
            InitializeComponent();
        }

        private void AdvLoan_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            fillGrid();


            comboBoxEmp.SelectedIndex = -1;

            SqlCommand cmd15 = new SqlCommand();
            cmd15.CommandText = "select EmpName from employee order by EmpName";
            DataSet DS1 = new DataSet();
            DS1 = DataManager.executeDataset(cmd15);


            comboBoxEmp.DataSource = DS1.Tables[0];
            comboBoxEmp.ValueMember = "EmpName";
            comboBoxEmp.DisplayMember = "EmpName";
            comboBoxEmp.SelectedItem = null;
            comboBoxEmp.SelectedText = null;
            comboBoxEmpS.DataSource = DS1.Tables[0];
            comboBoxEmpS.ValueMember = "EmpName";
            comboBoxEmpS.DisplayMember = "EmpName";
            comboBoxEmpS.SelectedItem = null;
            comboBoxEmpS.SelectedText = null;
        }
        void fillGrid()
        {
            SqlCommand Fetch = new SqlCommand();
            Fetch.CommandText = @"Select E.EmpId,E.EmpName,FV.Value,pf.Flag,Pf.Month,PF.year,PF.AdvAmount,PF.TransactionId
     from Employee E join AdvanceRecords PF on E.EmpId=PF.EId JOIN FlagValues FV ON PF.Flag=FV.FlagN WHERE PF.year=(SELECT YEAR(GETDATE()))";
            //dataGridViewMT.DataSource = DataManager.executeDataset(Fetch);
            SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(Fetch.CommandText, DataManager.connectionString);
            DataSet ds1 = new DataSet();
            dataadapter.Fill(ds1);

            dataGridViewMT.DataSource = ds1.Tables[0].DefaultView;

            dataGridViewMT.Columns["EmpId"].Visible = false;
            dataGridViewMT.Columns["Flag"].Visible = false;
            dataGridViewMT.Columns["Transactionid"].Visible = false;
            btnDelete.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (comboBoxEmp.Text == string.Empty)
            {
                MessageBox.Show("Please select Employee's name");
                return;
            }

            else if (comboBoxMonth.Text == string.Empty)
            {
                MessageBox.Show("Please select the Month");
                return;
            }
            else if (comboBoxYear.Text == string.Empty)
            {
                MessageBox.Show("Please select the year!");
                return;
            }
            else if (txtPfLoan.Text == string.Empty)
            {
                MessageBox.Show("Enter amount");
                return;
            }
            SqlCommand GetEmp = new SqlCommand();
            GetEmp.CommandText = "select EmpId from Employee Where EmpName=@EmpName";
            GetEmp.Parameters.AddWithValue("@EmpName", comboBoxEmp.SelectedValue);
            var empId = DataManager.executeScalar(GetEmp).ToString();
            
            SqlCommand Save = new SqlCommand();
            Save.CommandText = @"INSERT INTO AdvanceRecords 
                                  VALUES(@EmpId, @AdvAmount, @Month, @Year, @Flag)";
            Save.Parameters.AddWithValue("@EmpId", empId);
            Save.Parameters.AddWithValue("@AdvAmount", txtPfLoan.Text);
            Save.Parameters.AddWithValue("@Month", comboBoxMonth.Text);
            Save.Parameters.AddWithValue("@Year", comboBoxYear.Text);
            Save.Parameters.AddWithValue("@Flag", 0);
            DataManager.executeNonQuery(Save);
            PfLoan pf = new PfLoan();
            pf.Show();
            this.Hide();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string EmpName = comboBoxEmpS.Text;
            string Month = comboBoxM.Text;
            string Year = comboBoxY.Text;
            SqlCommand Fetch = new SqlCommand();
            Fetch.CommandText = @"Select E.EmpId,E.EmpName,FV.VALUE,pf.Flag,Pf.Month,PF.year,PF.AdvAmount,PF.Transactionid
                     from Employee E join AdvanceRecords PF on E.EmpId=PF.EId JOIN FlagValues FV ON PF.Flag=FV.FlagN WHERE E.EmpName 
                      like '%" + EmpName + "%' AND PF.Month Like '%" + Month + "%' and PF.Year like '%" + Year + "%' ORDER BY TRANSACTIONid ";
            //dataGridViewMT.DataSource = DataManager.executeDataset(Fetch);
            SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(Fetch.CommandText, DataManager.connectionString);
            DataSet ds1 = new DataSet();
            dataadapter.Fill(ds1);

            dataGridViewMT.DataSource = ds1.Tables[0].DefaultView;

            dataGridViewMT.Columns["EmpId"].Visible = false;
            dataGridViewMT.Columns["Transactionid"].Visible = false;
            btnDelete.Visible = false;
        }

        private void dataGridViewMT_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMT.SelectedRows)
            {


                labelTT.Text = row.Cells[7].Value.ToString();
                lblEmp.Text= row.Cells[0].Value.ToString();
                btnDelete.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this record.",
                    "Continue", MessageBoxButtons.YesNo);
            switch (dr)
            {

                case DialogResult.No: break;

            }
            if (dr == DialogResult.Yes)
            {
                SqlCommand cmdDel = new SqlCommand();
                cmdDel.CommandText = @"Delete from AdvanceRecords where transactionid=@id";
                cmdDel.Parameters.AddWithValue("id", labelTT.Text);
                int no = DataManager.executeNonQuery(cmdDel);
                if (no == 1)
                    MessageBox.Show("Deleted successsfully");
                else
                    MessageBox.Show("Something wrong Occured while performing delete");
                fillGrid();
            }
        }

        private void txtPfLoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                       (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp et = new Emp();
            et.Show();
            this.Hide();



        }
    }
}
