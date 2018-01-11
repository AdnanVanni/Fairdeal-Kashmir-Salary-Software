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
      
        }
        
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO[dbo].[Employee] ([EmpFname],[EmpLname],[AccNumber] ,[Department],[JoinDate],[SalaryPerMonth],[EmpType],[Designation] ,[AdvanceAmt],[PFloanWithdrawn],[MonthlyAdvAmountSubtracted],[MonthlyPFLoansubtracted],[Phone],[Email],[Parentage],[Residence]) values(@EmpFname, @EmpLname, @AccNumber, @Department, @JoinDate, @SalaryPerMonth, @EmpType, @Designation, @AdvanceAmt, @PFloanWithdrawn, @MonthlyAdvAmountSubtracted, @MonthlyPFLoansubtracted, @Phone, @Email,@Parentage,@Residence)";
            
            cmd.Parameters.AddWithValue("@EmpFname", txtFNmame.Text);
            cmd.Parameters.AddWithValue("@EmpLname", textLName.Text);
            cmd.Parameters.AddWithValue("@AccNumber", textAcc.Text);
            cmd.Parameters.AddWithValue("@Department", textDpt.Text);
            cmd.Parameters.AddWithValue("@JoinDate",dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@SalaryPerMonth",textMonthlySalary.Text);
            cmd.Parameters.AddWithValue("@EmpType", txtFNmame.Text);
            cmd.Parameters.AddWithValue("@Designation", textLName.Text);
            cmd.Parameters.AddWithValue("@AdvanceAmt",textAACD .Text);
            cmd.Parameters.AddWithValue("@PFloanWithdrawn", textPFLW.Text);
            cmd.Parameters.AddWithValue("@MonthlyAdvAmountSubtracted", textAAMD.Text);
            cmd.Parameters.AddWithValue("@MonthlyPFLoansubtracted",textPFMD.Text);
            cmd.Parameters.AddWithValue("@phone",textPhone.Text);
            cmd.Parameters.AddWithValue("@Email",textEmail.Text);
            cmd.Parameters.AddWithValue("@Parentage",textParentage.Text);
            cmd.Parameters.AddWithValue("@Residence",textResidence.Text);

            DataManager.executeNonQuery(cmd);
           

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
    
    }
}
