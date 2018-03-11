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
    public partial class Copy_Transactions : MetroFramework.Forms.MetroForm
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
            Copy.CommandText = "Insert into MonthlyTransaction SELECT @MonthT,E.EmployeeId,@YearT,E.TDC,E.Fine,E.SalaryInHand,E.PfMonthly,E.Memo,E.TransactionDate,E.AdvAmtSub,E.PfLoanSub,E.AbsentDays,E.DaysInMonth,E.Conv FROM MonthlyTransaction E JOIN Employee Emp on emp.EmpId = e.EmployeeId where emp.AdvanceAmt >=e.AdvAmtSub and emp.PFloanWithdrawn >= e.PfLoanSub and e.Month = @Month and Year = @Year"+ " INSERT INTO[dbo].[ArchiveTransactions] SELECT E.EmployeeId, Emp.EmpName, @MonthT, @YearT, emp.PFloanWithdrawn, E.PfLoanSub, emp.AdvanceAmt, e.AdvAmtSub, E.TDC, E.Conv, E.Fine, E.AbsentDays, Emp.SalaryPerMonth, SalaryInHand, E.Memo FROM MonthlyTransaction E JOIN Employee Emp on emp.EmpId = e.EmployeeId where emp.AdvanceAmt >= e.AdvAmtSub and emp.PFloanWithdrawn >= e.PfLoanSub and e.Month = @Month and E.Year = @Year";

            Copy.Parameters.AddWithValue("@Month", comboBoxMonthFrom.Text);
            Copy.Parameters.AddWithValue("@Year", comboBoxYearFrom.Text);
            Copy.Parameters.AddWithValue("@MonthT", comboBoxMonthTo.Text);
            Copy.Parameters.AddWithValue("@YearT", comboBoxYearTo.Text);
            try
            {
                DataManager.executeNonQuery(Copy);
            }
            catch(SqlException Ex)
            { 
                    //Your Message
                    MessageBox.Show(Ex.Message); 
            }
            SqlCommand NotCopied = new SqlCommand();
            NotCopied.CommandText = "SELECT Emp.EmpName FROM MonthlyTransaction E JOIN Employee Emp on emp.EmpId = e.EmployeeId where (emp.AdvanceAmt < e.AdvAmtSub OR emp.PFloanWithdrawn < e.PfLoanSub) and e.Month = @Month and E.Year = @Year";
            NotCopied.Parameters.AddWithValue("@Month", comboBoxMonthFrom.SelectedText);
            NotCopied.Parameters.AddWithValue("@Year", comboBoxYearFrom.SelectedText);
            try
            {

               DataSet DSNC = DataManager.executeDataset(NotCopied);
                listBoxEmployees.DataSource = DSNC.Tables[0];
            }
            catch (SqlException Ex)
            {
                //Your Message
                MessageBox.Show(Ex.Message);
            }
            listBoxEmployees.DisplayMember = "EmpName";

            listBoxEmployees.ValueMember = "EmpName";
            label4.Visible = true;
            listBoxEmployees.Visible = true;
            //const string sPath = "newhy.txt";
            //System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            ////foreach (object item in listBoxEmployees.Items)
            ////{
            ////    SaveFile.WriteLine(Convert.ToString(item));
            ////}
            //foreach (DataRowView drv in listBoxEmployees.Items)
            //{
            //    SaveFile.WriteLine(drv.Row[listBoxEmployees.ValueMember].ToString());
            //    //if you want to store all the idexes from your listbox, put them into an array 
            //}
            reportViewer1.Visible = true;
            this.copyTableAdapter.Fill(this.DataSetCopy.copy, comboBoxMonthFrom.Text, comboBoxYearFrom.Text);

            this.reportViewer1.RefreshReport();

        }

        private void Copy_Transactions_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            label4.Visible = false;
            listBoxEmployees.Visible = false;
            reportViewer1.Visible = false;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp E = new Emp();
            E.Show();
            this.Hide();
        }
    }
}
