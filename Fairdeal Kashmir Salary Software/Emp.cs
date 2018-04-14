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
    public partial class Emp : MetroFramework.Forms.MetroForm
    {
        public Emp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            fillGrid();
            comboBoxDept.SelectedIndex = -1;
            label1.Visible = false;
            btnDelete.Visible = false;
            SqlCommand cmdDept = new SqlCommand();
            cmdDept.CommandText = "SELECT * from Departments order by departmentName";
            DataSet DSdept =DataManager.executeDataset(cmdDept);
            comboBoxDept.DataSource = DSdept.Tables[0];
            comboBoxDept.ValueMember = "DepartmentName";
            comboBoxDept.DisplayMember = "DepartmentName";
            comboBoxDept.Text = "--Select--";
            SqlCommand cmdDesg = new SqlCommand();
            cmdDesg.CommandText = "SELECT * from Designations order by designation";
            DataSet DSdesg = DataManager.executeDataset(cmdDesg);
            textDesignation.DataSource = DSdesg.Tables[0];
            textDesignation.ValueMember = "Designation";
            textDesignation.DisplayMember = "Designation";
            textDesignation.Text = "";




        }
        private void fillGrid()
        {
            try
            {
                SqlCommand cmdd = new SqlCommand();
                cmdd.CommandText = "SELECT * FROM Employee order by EmpName";
                SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(cmdd.CommandText, DataManager.connectionString);
                DataSet ds1 = new DataSet();
                dataadapter.Fill(ds1, "Employee");
                dataGridViewEmp.DataSource = ds1;
                dataGridViewEmp.DataMember = "Employee";
                dataGridViewEmp.Columns[1].HeaderText = "Name";
                dataGridViewEmp.Columns[2].HeaderText = "Account No.";
                dataGridViewEmp.Columns[0].Visible = false;
                dataGridViewEmp.Columns[4].Visible = false;
                dataGridViewEmp.Columns[5].Visible = false;
                dataGridViewEmp.Columns[6].Visible = false;
                dataGridViewEmp.Columns[8].Visible = false;
                dataGridViewEmp.Columns[9].Visible = false;
                dataGridViewEmp.Columns[10].Visible = false;
                dataGridViewEmp.Columns[11].Visible = false;
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void fillGridSearch(string key)
        {
            try
            {
                SqlCommand cmdd = new SqlCommand();
                cmdd.CommandText = "SELECT * FROM Employee where empName like '%" + @key + "%' order by empName";
                cmdd.Parameters.AddWithValue("@key", key);
                SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(cmdd.CommandText, DataManager.connectionString);
                connection1.Open();
                DataSet ds1 = new DataSet();
                dataadapter.Fill(ds1, "Employee");
                connection1.Close();
                dataGridViewEmp.DataSource = ds1;
                dataGridViewEmp.DataMember = "Employee";
                dataGridViewEmp.Columns[1].HeaderText = "Name";
                dataGridViewEmp.Columns[2].HeaderText = "Account No.";
                dataGridViewEmp.Columns[0].Visible = false;
                dataGridViewEmp.Columns[4].Visible = false;
                dataGridViewEmp.Columns[5].Visible = false;
                dataGridViewEmp.Columns[6].Visible = false;
                dataGridViewEmp.Columns[8].Visible = false;
                dataGridViewEmp.Columns[9].Visible = false;
                dataGridViewEmp.Columns[10].Visible = false;
                dataGridViewEmp.Columns[11].Visible = false;
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAid.Text == string.Empty)
            {
                MessageBox.Show("Please enter Employee's Id");
                return;
            }
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Employee's name");
                return;
            }
            if (comboBoxDept.Text == "--Select--")
            {
                MessageBox.Show("Please select the department");
                return;
            }

            else if (comboBoxDept.Text == string.Empty)
            {
                MessageBox.Show("Please select the department");
                return;
            }
            else if (textAcc.Text == string.Empty)
            {
                MessageBox.Show("Please enter account number!");
                return;
            }

            else {
                try
                {


                    SqlCommand cmd = new SqlCommand();
                    if (btnSave.Text == "Save")
                    {
                        cmd.CommandText = "insert into Employee values  (@EmpName,  @AccNumber, @Department, @JoinDate, @SalaryPerMonth, @EmpType, @Designation, @AdvanceAmt, @PFloanWithdrawn, @MonthlyAdvAmountSubtracted, @MonthlyPFLoansubtracted, @Phone, @Email,@Parentage,@Residence,@AId,@PFAccNo,@ConvPerMonth)";
                    }
                    if (btnSave.Text == "Update")
                    {
                        cmd.CommandText = "UPDATE [dbo].[Employee] SET[EmpName] = @EmpName,[AccNumber] = @AccNumber,[Department] = @Department,[JoinDate] = @JoinDate,[SalaryPerMonth] = @SalaryPerMonth,[EmpType] = @EmpType,[Designation] = @Designation, [AdvanceAmt] = @AdvanceAmt,[PFloanWithdrawn] = @PFloanWithdrawn,[MonthlyAdvAmountSubtracted] = @MonthlyAdvAmountSubtracted,[MonthlyPFLoansubtracted] = @MonthlyPFLoansubtracted,[Phone] = @Phone,[Email] = @Email,[Parentage] = @Parentage,[Residence] = @Residence ,AID=@AId,PFAccNo=@PFAccNo,ConvPerMonth=@ConvPerMonth where empId=@label1";
                    }

                    cmd.Parameters.AddWithValue("@EmpName", txtName.Text);
                    cmd.Parameters.AddWithValue("@AccNumber", textAcc.Text);
                    cmd.Parameters.AddWithValue("@Department", comboBoxDept.SelectedValue);
                    cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@SalaryPerMonth", textMonthlySalary.Text);
                    cmd.Parameters.AddWithValue("@EmpType", "");
                    cmd.Parameters.AddWithValue("@AdvanceAmt", textAACD.Text);
                    cmd.Parameters.AddWithValue("@PFloanWithdrawn", textPFLW.Text);
                    cmd.Parameters.AddWithValue("@MonthlyAdvAmountSubtracted", textAAMD.Text);
                    cmd.Parameters.AddWithValue("@Designation", textDesignation.Text);
                    cmd.Parameters.AddWithValue("@MonthlyPFLoansubtracted", textPFMD.Text);
                    cmd.Parameters.AddWithValue("@phone", textPhone.Text);
                    cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@Parentage", textParentage.Text);
                    cmd.Parameters.AddWithValue("@Residence", textResidence.Text);
                    cmd.Parameters.AddWithValue("@label1", label1.Text);
                    cmd.Parameters.AddWithValue("@AId", txtAid.Text);
                    cmd.Parameters.AddWithValue("@PFAccNo", txtPFaccNo.Text);
                    cmd.Parameters.AddWithValue("@ConvPerMonth", textBoxConv.Text);
                    cmd.Connection = new SqlConnection();
                    DataManager.executeNonQuery(cmd);
                    MessageBox.Show("Saved");
                    Emp emp = new Emp();
                    emp.Tag = this;
                    emp.Show(this);
                    Hide();
                }
                catch (SqlException Ex)
                {
                    if (Ex.Number == 2627)
                    {
                        MessageBox.Show("You Are Trying To save Duplicate records");

                    }
                    else
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }

            /*/*txtName.Text = "done"*/
            

        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
      
        private void textMonthlySalary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPFMD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textAACD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textAAMD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPFLW_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp emp1 = new Emp();
            emp1.Show();
            this.Hide();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deptt d = new Deptt();
            d.Show();
            this.Hide();
        }

        private void createMonthsTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monthly_Transaction m = new Monthly_Transaction();
            m.Show();
            this.Hide();
        }

        private void dataGridViewEmp_SelectionChanged(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            foreach (DataGridViewRow row in dataGridViewEmp.SelectedRows)
            {

                label2.Text = "*Please note that you are updating " + row.Cells[1].Value.ToString() + "'s details";
                label2.ForeColor = System.Drawing.Color.Red;
                btnSave.Text = "Update";
                label1.Text =  row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                textParentage.Text= row.Cells[14].Value.ToString();
                textPhone.Text= row.Cells[12].Value.ToString();
                textEmail.Text= row.Cells[13].Value.ToString();
                comboBoxDept.Text= row.Cells[3].Value.ToString();
                textResidence.Text= row.Cells[15].Value.ToString();
                dateTimePicker1.Text= row.Cells[4].Value.ToString();

                
                
                textAcc.Text= row.Cells[2].Value.ToString();
                textMonthlySalary.Text= row.Cells[5].Value.ToString();
                textPFLW.Text= row.Cells[9].Value.ToString();
                textPFMD.Text= row.Cells[11].Value.ToString();
                textAACD.Text= row.Cells[8].Value.ToString(); ;
                textAAMD.Text= row.Cells[10].Value.ToString();
                textDesignation.Text = row.Cells[7].Value.ToString();
                txtAid.Text= row.Cells[16].Value.ToString();
                textBoxConv.Text= row.Cells[18].Value.ToString();
                txtPFaccNo.Text= row.Cells[17].Value.ToString();

                //...

            }
    }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdDel = new SqlCommand();
                cmdDel.CommandText = "delete from Employee where empId=@empId";
                cmdDel.Parameters.AddWithValue("@empId", label1.Text);
                DataManager.executeNonQuery(cmdDel);
                MessageBox.Show("Delete successful");
                Emp emp1 = new Emp();
                emp1.Show();
                this.Hide();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void textPFMD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAAMD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAACD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPFLW_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddNew_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Tag = this;
            emp.Show(this);
            Hide();
        }

        private void textMonthlySalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelAdvAmt_Click(object sender, EventArgs e)
        {

        }

        private void labelAdvancedMonthlyDeduction_Click(object sender, EventArgs e)
        {

        }

        private void labelPFloanMonthlyDeduction_Click(object sender, EventArgs e)
        {

        }

        private void labelPFLoanWithdrawn_Click(object sender, EventArgs e)
        {

        }

        private void labelSalary_Click(object sender, EventArgs e)
        {

        }

        private void textAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxEmpType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textResidence_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelResidence_Click(object sender, EventArgs e)
        {

        }

        private void labelJoinDate_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillGridSearch(txtSeach.Text);
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm1 RP1 = new ReportForm1();
            RP1.Show();
            this.Hide();
        }

        private void report2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryBill  rp = new SalaryBill();
            rp.Show();
            this.Hide();
        }

        private void addDesignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Designation d = new Designation();
            d.Show();
            this.Hide();
        }

        private void copyTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy_Transactions ct = new Copy_Transactions();
            ct.Show();
            this.Hide();
        }

        private void backupDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyInfo CI = new CompanyInfo();
            CI.Show();
            this.Hide();
        }

        private void pFReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PfForm PF = new PfForm();
            PF.Show();
            this.Hide();
        }

        private void textBoxConv_KeyPress(object sender, KeyPressEventArgs e)
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

        private void archivedTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void pFLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PfLoan PF = new PfLoan();
            PF.Show();
            this.Hide();
            
        }

        private void advanceLoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvLoan ad = new AdvLoan();
            ad.Show();
            this.Hide();
        }

        private void generalRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GeneralRecords gr = new GeneralRecords();
            gr.Show();
            this.Hide();
        }
    }
}
