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
            Copy.CommandText = @"Insert into MonthlyTransaction SELECT @MonthT,E.EmployeeId,@YearT,E.TDC,
                E.Fine,E.SalaryInHand,E.PfMonthly,E.Memo,E.TransactionDate,E.AdvAmtSub,E.PfLoanSub,
            E.AbsentDays,E.DaysInMonth,E.Conv FROM MonthlyTransaction E JOIN Employee
                Emp on emp.EmpId = e.EmployeeId where  e.Month = @Month and
                Year = @Year and E.EmployeeId in (   select EmpId from(select EmpName,EMPID,	
 SumPF FROM EMPLOYEE INNER JOIN  (Select EId,Sum(Case Flag
                                           when '0' then pfamount 
										   when '1' then -PfAmount
										   when '2' then 0 end) as SumPF from PfRecords group by EId)P
										   ON  P.EId=EMPLOYEE.EmpId inner join MonthlyTransaction MT ON Employee.EmpId=mt.EmployeeId where
										    mt.month=@month and mt.year=@year and (MT.PfLoanSub)<=(SumPF))k

intersect

	 select empid from (select EmpName,EMPID,AdvanceAmt,isnull(P.SumAdv+AdvanceAmt,0) as
					  Total,P.SumAdv FROM EMPLOYEE INNER JOIN  (Select EId,Sum(Case Flag
                                           when '0' then AdvAmount 
										   when '1' then -advAmount
										    end) as SumAdv from AdvanceRecords group by EId)P
										   ON  P.EId=EMPLOYEE.EmpId inner join MonthlyTransaction MT ON Employee.EmpId=mt.EmployeeId where mt.month=@month and mt.year=@year and (MT.AdvAmtSub)<=(Sumadv)
										   )l)






















INSERT INTO PFRECORDS select Eid,PfAmount,@MonthT,@YearT,Flag from pfrecords where month=@Month and year=@Year AND FLAG<>0 and EId in(
(select EMPID FROM EMPLOYEE INNER JOIN  (Select EId,Sum(Case Flag
                                           when '0' then pfamount 
										   when '1' then -PfAmount
										   when '2' then 0 end) as 
										   SumPF from PfRecords group by EId)P
										   ON  P.EId=EMPLOYEE.EmpId
										    inner join MonthlyTransaction MT 
											ON Employee.EmpId=mt.EmployeeId 
											where
										    mt.month=@Month and mt.year=@Year and (MT.PfLoanSub)<=(SumPF))

											intersect

	( select empid FROM EMPLOYEE INNER JOIN  (Select EId,Sum(Case Flag
                                           when '0' then AdvAmount 
										   when '1' then -advAmount
										    end) as SumAdv from AdvanceRecords group by EId)P
										   ON  P.EId=EMPLOYEE.EmpId inner join MonthlyTransaction MT ON Employee.EmpId=mt.EmployeeId where mt.month=@month and mt.year=@year and (MT.AdvAmtSub)<=(Sumadv)
										 )

										 )


											INSERT INTO AdvanceRecords 
											select Eid,AdvAmount,@MonthT,@YearT,Flag from AdvanceRecords where month=@Month and year=@Year and FLAG<>0 AND EId in
(select EMPID FROM EMPLOYEE INNER JOIN  (Select EId,Sum(Case Flag
                                           when '0' then AdvAmount 
										   when '1' then -AdvAmount
										   end) as 
										   Sumadv from AdvanceRecords group by EId)P
										   ON  P.EId=EMPLOYEE.EmpId
										    inner join MonthlyTransaction MT 
											ON Employee.EmpId=mt.EmployeeId 
											where
										    mt.month=@Month and mt.year=@Year and (MT.PfLoanSub)<=(Sumadv)
											INTERSECT
											
(select EMPID FROM EMPLOYEE INNER JOIN  (Select EId,Sum(Case Flag
                                           when '0' then pfamount 
										   when '1' then -PfAmount
										   when '2' then 0 end) as 
										   SumPF from PfRecords group by EId)P
										   ON  P.EId=EMPLOYEE.EmpId
										    inner join MonthlyTransaction MT 
											ON Employee.EmpId=mt.EmployeeId 
											where
										    mt.month=@Month and mt.year=@Year and (MT.PfLoanSub)<=(SumPF)))



















						

						
INSERT INTO [dbo].[ArchiveTransactions]
        SELECT E.EmployeeId, Emp.EmpName, @MonthT, @YearT, emp.PFloanWithdrawn,
                    E.PfLoanSub, emp.AdvanceAmt, e.AdvAmtSub, E.TDC, E.Conv, E.Fine,
                    E.AbsentDays, Emp.SalaryPerMonth, SalaryInHand, E.Memo FROM MonthlyTransaction
                     E JOIN Employee Emp on emp.EmpId = e.EmployeeId where e.Month = @Month and E.Year = @Year  and E.EmployeeId in (  select EmpId from(select EmpName,EMPID,	
 SumPF FROM EMPLOYEE INNER JOIN  (Select EId,Sum(Case Flag
                                           when '0' then pfamount 
										   when '1' then -PfAmount
										   when '2' then 0 end) as SumPF from PfRecords group by EId)P
										   ON  P.EId=EMPLOYEE.EmpId inner join MonthlyTransaction MT ON Employee.EmpId=mt.EmployeeId where
										    mt.month=@Month and mt.year=@Year and (MT.PfLoanSub)<=(SumPF))k

intersect

	 select empid from (select EmpName,EMPID,AdvanceAmt,isnull(P.SumAdv+AdvanceAmt,0) as
					  Total,P.SumAdv FROM EMPLOYEE INNER JOIN  (Select EId,Sum(Case Flag
                                           when '0' then AdvAmount 
										   when '1' then -advAmount
										    end) as SumAdv from AdvanceRecords group by EId)P
										   ON  P.EId=EMPLOYEE.EmpId inner join MonthlyTransaction MT ON Employee.EmpId=mt.EmployeeId
where mt.month=@Month and mt.year=@Year and (MT.AdvAmtSub)<=(Sumadv)
										   )l)
						";

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
            label4.Visible = true;
            reportViewer2.Visible = true;
            // TODO: This line of code loads data into the 'DataSetCopyNot.NotCopiedList' table. You can move, or remove it, as needed.
            this.NotCopiedListTableAdapter.Fill(this.DataSetCopyNot.NotCopiedList, comboBoxMonthFrom.Text, comboBoxYearFrom.Text);
            this.reportViewer2.RefreshReport();
            //SqlCommand NotCopied = new SqlCommand();
            //NotCopied.CommandText = "SELECT Emp.EmpName FROM MonthlyTransaction E JOIN Employee Emp on emp.EmpId = e.EmployeeId where (emp.AdvanceAmt < e.AdvAmtSub OR emp.PFloanWithdrawn < e.PfLoanSub) and e.Month = @Month and E.Year = @Year";
            //NotCopied.Parameters.AddWithValue("@Month", comboBoxMonthFrom.SelectedText);
            //NotCopied.Parameters.AddWithValue("@Year", comboBoxYearFrom.SelectedText);
            //try
            //{

            //   DataSet DSNC = DataManager.executeDataset(NotCopied);
            //    listBoxEmployees.DataSource = DSNC.Tables[0];
            //}
            //catch (SqlException Ex)
            //{
            //    //Your Message
            //    MessageBox.Show(Ex.Message);
            //}
            //listBoxEmployees.DisplayMember = "EmpName";

            //listBoxEmployees.ValueMember = "EmpName";
            //label4.Visible = true;
            //listBoxEmployees.Visible = true;
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
            //reportViewer1.Visible = true;
            //this.copyTableAdapter.Fill(this.DataSetCopy.copy, comboBoxMonthFrom.Text, comboBoxYearFrom.Text);

            //this.reportViewer1.RefreshReport();

        }

        private void Copy_Transactions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCopyNot.NotCopiedList' table. You can move, or remove it, as needed.
            //this.NotCopiedListTableAdapter.Fill(this.DataSetCopyNot.NotCopiedList,comboBoxMonthFrom.Text,comboBoxYearFrom.Text);
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
