﻿using System;
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
    public partial class Emp : Form
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
            label1.Visible = false;
            btnDelete.Visible = false;
            SqlCommand cmdDept = new SqlCommand();
            cmdDept.CommandText = "SELECT * from Departments";
            DataSet DSdept =DataManager.executeDataset(cmdDept);
            comboBoxDept.DataSource = DSdept.Tables[0];
            comboBoxDept.ValueMember = "DepartmentName";
            comboBoxDept.DisplayMember = "DepartmentName";

            
          
            
        }
        private void fillGrid()
        { 
            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "SELECT * FROM Employee";
            SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(cmdd.CommandText, DataManager.connectionString);
            connection1.Open();
            DataSet ds1 = new DataSet();
            dataadapter.Fill(ds1, "Employee");
            connection1.Close();
            dataGridViewEmp.DataSource = ds1;
            dataGridViewEmp.DataMember = "Employee";
            dataGridViewEmp.Columns[0].Visible = false;
            dataGridViewEmp.Columns[4].Visible = false;
            dataGridViewEmp.Columns[5].Visible = false;
            dataGridViewEmp.Columns[6].Visible = false;
            dataGridViewEmp.Columns[8].Visible = false;
            dataGridViewEmp.Columns[9].Visible = false;
            dataGridViewEmp.Columns[10].Visible = false;
            dataGridViewEmp.Columns[11].Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Employee's name");
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



                SqlCommand cmd = new SqlCommand();
                if (btnSave.Text == "Save")
                {
                    cmd.CommandText = "insert into Employee values  (@EmpName,  @AccNumber, @Department, @JoinDate, @SalaryPerMonth, @EmpType, @Designation, @AdvanceAmt, @PFloanWithdrawn, @MonthlyAdvAmountSubtracted, @MonthlyPFLoansubtracted, @Phone, @Email,@Parentage,@Residence)";
                }
                if (btnSave.Text == "Update")
                {
                    cmd.CommandText = "UPDATE [dbo].[Employee] SET[EmpName] = @EmpName,[AccNumber] = @AccNumber,[Department] = @Department,[JoinDate] = @JoinDate,[SalaryPerMonth] = @SalaryPerMonth,[EmpType] = @EmpType,[Designation] = @Designation, [AdvanceAmt] = @AdvanceAmt,[PFloanWithdrawn] = @PFloanWithdrawn,[MonthlyAdvAmountSubtracted] = @MonthlyAdvAmountSubtracted,[MonthlyPFLoansubtracted] = @MonthlyPFLoansubtracted,[Phone] = @Phone,[Email] = @Email,[Parentage] = @Parentage,[Residence] = @Residence where empId=@label1";
                }

                cmd.Parameters.AddWithValue("@EmpName", txtName.Text);
                cmd.Parameters.AddWithValue("@AccNumber", textAcc.Text);
                cmd.Parameters.AddWithValue("@Department",comboBoxDept.SelectedValue);
                cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@SalaryPerMonth", textMonthlySalary.Text);
                cmd.Parameters.AddWithValue("@EmpType", listBoxEmpType.Text);
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
                cmd.Connection = new SqlConnection();
                DataManager.executeNonQuery(cmd);
                MessageBox.Show("Saved");
                Emp emp = new Emp();
                emp.Tag = this;
                emp.Show(this);
                Hide();
            }

            /*/*txtName.Text = "done"*/
            

        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Tag = this;
            emp.Show(this);
            Hide();
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
                btnSave.Text = "Update";
                label1.Text =  row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                textParentage.Text= row.Cells[14].Value.ToString();
                textPhone.Text= row.Cells[12].Value.ToString();
                textEmail.Text= row.Cells[13].Value.ToString();
                comboBoxDept.Text= row.Cells[3].Value.ToString();
                textResidence.Text= row.Cells[15].Value.ToString();
                dateTimePicker1.Text= row.Cells[4].Value.ToString();
                listBoxEmpType.SelectedValue= row.Cells[6].Value.ToString();
                textDesignation.Text= row.Cells[9].Value.ToString();
                textAcc.Text= row.Cells[2].Value.ToString();
                textMonthlySalary.Text= row.Cells[5].Value.ToString();
                textPFLW.Text= row.Cells[9].Value.ToString();
                textPFMD.Text= row.Cells[11].Value.ToString();
                textAACD.Text= row.Cells[8].Value.ToString(); ;
                textAAMD.Text= row.Cells[10].Value.ToString();
                //...

            }
    }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
