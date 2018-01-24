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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Employee's name");
                return;
            }
            
            else if (textDpt.Text == string.Empty)
            {
                MessageBox.Show("Please enter the department");
                return;
            }
            else if (textAcc.Text == string.Empty)
            {
                MessageBox.Show("Please enter account number!");
                return;
            }
           
            else { 


           
            SqlCommand cmd = new SqlCommand();
                if (btnSave.Text =="Save")
                {
                    cmd.CommandText = "insert into departments values (@EmpName,  @AccNumber, @Department, @JoinDate, @SalaryPerMonth, @EmpType, @Designation, @AdvanceAmt, @PFloanWithdrawn, @MonthlyAdvAmountSubtracted, @MonthlyPFLoansubtracted, @Phone, @Email,@Parentage)";
                }
                if(btnSave.Text=="Update")
                {
                    cmd.CommandText = "UPDATE [dbo].[Employee] SET[EmpFname] = @EmpName,[AccNumber] = @AccNumber,[Department] = @Department,[JoinDate] = @JoinDate,[SalaryPerMonth] = @SalaryPerMonth,[EmpType] = @EmpType,[Designation] = @Designation, [AdvanceAmt] = @AdvanceAmt,[PFloanWithdrawn] = @PFloanWithdrawn,[MonthlyAdvAmountSubtracted] = @MonthlyAdvAmountSubtracted,[MonthlyPFLoansubtracted] = @MonthlyPFLoansubtracted,[Phone] = @Phone,[Email] = @Email,[Parentage] = @Parentage,[Residence] = @Residence where empId=@label1";
                }

                cmd.Parameters.AddWithValue("@EmpName", txtName.Text);
                cmd.Parameters.AddWithValue("@AccNumber", textAcc.Text);
                cmd.Parameters.AddWithValue("@Department", textDpt.Text);
                cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@SalaryPerMonth", textMonthlySalary.Text);
                cmd.Parameters.AddWithValue("@EmpType", listBoxEmpType.Text);
                cmd.Parameters.AddWithValue("@AdvanceAmt", textAACD.Text);
                cmd.Parameters.AddWithValue("@PFloanWithdrawn", textPFLW.Text);
                cmd.Parameters.AddWithValue("@MonthlyAdvAmountSubtracted", textAAMD.Text);
                cmd.Parameters.AddWithValue("@MonthlyPFLoansubtracted", textPFMD.Text);
                cmd.Parameters.AddWithValue("@phone", textPhone.Text);
                cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                cmd.Parameters.AddWithValue("@Parentage", textParentage.Text);
                cmd.Parameters.AddWithValue("@Residence",textResidence.Text);
                cmd.Parameters.AddWithValue("@label1", label1.Text);
                cmd.Connection = new SqlConnection();
                DataManager.executeNonQuery(cmd);
            }
           
            txtName.Text = "done";

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
           
            foreach (DataGridViewRow row in dataGridViewEmp.SelectedRows)
            {
                btnSave.Text = "Update";
                label1.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                textParentage.Text = row.Cells[1].Value.ToString();
                text
                //...
            }
        
    }
    }
}
