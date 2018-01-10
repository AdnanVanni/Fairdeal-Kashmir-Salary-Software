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
        }
        
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFNmame.Text == string.Empty)
            {
                MessageBox.Show("Please enter Employee's first name");
                return;
            }
            else if (textLName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Employee's last name");
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
                cmd.CommandText = "insert into departments values (@EmpFname, @EmpLname, @AccNumber, @Department, @JoinDate, @SalaryPerMonth, @EmpType, @Designation, @AdvanceAmt, @PFloanWithdrawn, @MonthlyAdvAmountSubtracted, @MonthlyPFLoansubtracted, @Phone, @Email,@Parentage)";


                cmd.Parameters.AddWithValue("@EmpFname", txtFNmame.Text);
                cmd.Parameters.AddWithValue("@EmpLname", textLName.Text);
                cmd.Parameters.AddWithValue("@AccNumber", textAcc.Text);
                cmd.Parameters.AddWithValue("@Department", textDpt.Text);
                cmd.Parameters.AddWithValue("@JoinDate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@SalaryPerMonth", textMonthlySalary.Text);
                cmd.Parameters.AddWithValue("@EmpType", txtFNmame.Text);
                cmd.Parameters.AddWithValue("@Designation", textLName.Text);
                cmd.Parameters.AddWithValue("@AdvanceAmt", textAACD.Text);
                cmd.Parameters.AddWithValue("@PFloanWithdrawn", textPFLW.Text);
                cmd.Parameters.AddWithValue("@MonthlyAdvAmountSubtracted", textAAMD.Text);
                cmd.Parameters.AddWithValue("@MonthlyPFLoansubtracted", textPFMD.Text);
                cmd.Parameters.AddWithValue("@phone", textPhone.Text);
                cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                cmd.Parameters.AddWithValue("@Parentage", textParentage.Text);
                cmd.Parameters.AddWithValue("@Residence",textResidence.Text);
                cmd.Connection = new SqlConnection();
                DataManager.executeNonQuery(cmd);
            }
           
            txtFNmame.Text = "done";

        }

        private void editEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emp emp = new Emp();
            emp.Tag = this;
            emp.Show(this);
            Hide();
        }
    }
}
