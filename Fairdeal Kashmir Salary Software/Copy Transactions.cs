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
    public partial class Copy_Transactions : Form
    {
        public Copy_Transactions()
        {
            InitializeComponent();
        }

        private void btnCpy_Click(object sender, EventArgs e)
        {
            if (comboBoxMonthFrom.Text == string.Empty)
            {
                MessageBox.Show("Select Month");
            }
            if (comboBoxYearFrom.Text == string.Empty)
            {
                MessageBox.Show("Select Year");
            }
            if (comboBoxMonthTo.Text == string.Empty)
            {
                MessageBox.Show("Select Month");
            }
            if (comboBoxYearTo.Text == string.Empty)
            {
                MessageBox.Show("Select Year");
            }
            SqlCommand Copy = new SqlCommand();
            Copy.CommandText = "Insert into MonthlyTransaction SELECT @MonthT,E.EmployeeId,@YearT,E.TDC,E.Fine,E.SalaryInHand,E.PfMonthly,E.Benefits,E.Memo,E.TransactionDate,E.AdvAmtSub,E.PfLoanSub,E.AbsentDays,E.DaysInMonth FROM MonthlyTransaction E JOIN Employee Emp on emp.EmpId = e.EmployeeId where emp.AdvanceAmt > e.AdvAmtSub and emp.PFloanWithdrawn > e.PfLoanSub and e.Month = @Month and Year = @Year";
            Copy.Parameters.AddWithValue("@Month", comboBoxMonthFrom.Text);
            Copy.Parameters.AddWithValue("@Year", comboBoxYearFrom.Text);
            Copy.Parameters.AddWithValue("@MonthT", comboBoxMonthTo.Text);
            Copy.Parameters.AddWithValue("@YearT", comboBoxYearTo);
            SqlCommand NotCopied = new SqlCommand();
            NotCopied.CommandText = "SELECT Emp.EmpName FROM MonthlyTransaction E JOIN Employee Emp on emp.EmpId = e.EmployeeId where (emp.AdvanceAmt < e.AdvAmtSub OR emp.PFloanWithdrawn < e.PfLoanSub) and e.Month = 'MAY' and E.Year = '2020'";
            NotCopied.Parameters.AddWithValue("@Month", comboBoxMonthFrom.Text);
            NotCopied.Parameters.AddWithValue("@Year", comboBoxYearFrom.Text);
            DataSet DSNC = DataManager.executeDataset(NotCopied);
            listBoxEmployees.DataSource = DSNC.Tables[0];
            listBoxEmployees.DisplayMember = "EmpName";
        }
        }
}
