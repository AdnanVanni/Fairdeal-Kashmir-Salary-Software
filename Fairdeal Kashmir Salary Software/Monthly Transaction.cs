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
    public partial class Monthly_Transaction : MetroFramework.Forms.MetroForm
    {
        public bool flagload = false;
        public Monthly_Transaction()
        {
            
            InitializeComponent();
        }

        private void Monthly_Transaction_Load(object sender, EventArgs e)
        {
            labelPrompt.Visible = false;


            btnDelete.Visible = false;

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            FillGrid();
            Ename.SelectedIndex = -1;

            SqlCommand cmd15 = new SqlCommand();
            cmd15.CommandText = "select EmpName from employee order by EmpName ";
            DataSet DS1 = new DataSet();
            DS1 = DataManager.executeDataset(cmd15);


            Ename.DataSource = DS1.Tables[0];
            Ename.ValueMember = "EmpName";
            Ename.DisplayMember = "EmpName";
            txtAbsent.Text = Convert.ToString(0);
            //  dataGridViewMT.Rows[0].Selected = false;
            Ename.SelectedItem = null;
            Ename.SelectedText = null;




            //const int JANUARY = 1;
            //const int FEBRUARY = 2;
            //const int MARCH = 3;
            //const int APRIL = 4;
            //const int MAY = 5;
            //const int JUNE = 6;
            //const int JULY = 7;
            //const int AUGUST = 8;
            //const int SEPTEMBER = 9;
            //const int OCTOBER = 10;
            //const int NOVEMBER = 11;
            //const int DECEMBER = 12;
            flagload = true;
        }
        private void FillGrid()
        {
            try
            {
                SqlCommand Fetch = new SqlCommand();
                Fetch.CommandText = "select MT.Month,MT.Year,E.EmpId,MT.EmployeeId,E.EmpName,E.Department,E.SalaryPerMonth,MT.SalaryInHand,E.AdvanceAmt,E.PFloanWithdrawn,MT.TransactionDate,MT.Conv from Employee E join MonthlyTransaction MT ON E.EmpId=MT.EmployeeId WHERE MT.Year=(SELECT YEAR(GETDATE())) and MT.MONTH=(SELECT datename(month,GETDATE())) ORDER BY TRANSACTIONDATE";
                //dataGridViewMT.DataSource = DataManager.executeDataset(Fetch);
                SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(Fetch.CommandText, DataManager.connectionString);
                DataSet ds1 = new DataSet();
                dataadapter.Fill(ds1);

                dataGridViewMT.DataSource = ds1.Tables[0].DefaultView;

                dataGridViewMT.Columns["EmpId"].Visible = false;
                dataGridViewMT.Columns["EmployeeId"].Visible = false;
                dataGridViewMT.Columns["TransactionDate"].Visible = false;
                dataGridViewMT.Columns["AdvanceAmt"].Visible = false;
                dataGridViewMT.Columns["PFloanWithdrawn"].Visible = false;
                dataGridViewMT.Columns["SalaryPerMonth"].HeaderText = "Actual Salary";
                dataGridViewMT.Columns["EmpName"].HeaderText = "Name";
                btnDelete.Visible = false;
            }
            catch (SqlException Ex)
            {
                if (Ex.Number == 2627)
                {
                    MessageBox.Show("You Are Trying To save Duplicate records");
                }else
                    MessageBox.Show(Ex.Message);
            }
        
           
        }
        private void txtSaveRecord_Click(object sender, EventArgs e)
        {
            if (Ename.Text == string.Empty)
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
            else if (txtNetSalary.Text == string.Empty)
            {
                MessageBox.Show("Net Salary not calculated");
                return;
            }
            labelPrompt.Visible = true;
            SqlCommand GetEmp = new SqlCommand();
            GetEmp.CommandText = "select EmpId from Employee Where EmpName=@EmpName";
            GetEmp.Parameters.AddWithValue("@EmpName", Ename.SelectedValue);
            var empId = DataManager.executeScalar(GetEmp).ToString();

            //Checks if transaction Can be committed
            SqlCommand Check = new SqlCommand();
            Check.CommandText = @"Select isnull(PFloanWithdrawn,0) from Employee  where empId=@EmpId
Select isnull(sum(PFAmount),0) from Pfrecords where eId=@EmpId and Flag=0
Select isnull(sum(PFAmount),0)from Pfrecords where eId=@EmpId and Flag=1
Select isnull(sum(PFAmount),0) from Pfrecords where eId=@EmpId and Flag=2
            Select isnull(AdvanceAmt,0) from Employee where empId=@EmpId
Select isnull(sum(AdvAmount),0) from AdvanceRecords where eId=@EmpId and Flag=0
Select isnull(sum(AdvAmount),0) from AdvanceRecords where eId=@EmpId and Flag=1";
            Check.Parameters.AddWithValue("@EmpId", empId);
            DataSet dsE= DataManager.executeDataset(Check);
            var OB = dsE.Tables[0].Rows[0][0].ToString();
            var Loan= dsE.Tables[1].Rows[0][0].ToString();
            var refund=dsE.Tables[2].Rows[0][0].ToString();
            var MonPf = dsE.Tables[3].Rows[0][0].ToString();
            var OB1 = dsE.Tables[4].Rows[0][0].ToString();
            var Loan1 = dsE.Tables[5].Rows[0][0].ToString();
            var refund1 = dsE.Tables[6].Rows[0][0].ToString();
            Double RemaningPf =   Convert.ToDouble(Loan)- Convert.ToDouble(refund);
            Double RemaningAdv = Convert.ToDouble(Loan1)-Convert.ToDouble(refund1) ;

          
            if (RemaningAdv >= Convert.ToDouble(txtAAMD.Text) &&  RemaningPf >= Convert.ToDouble(txtMPFLS.Text))
            {
                //saves record in monthly transaction
                SqlCommand Save = new SqlCommand();
                Save.CommandText = @"INSERT INTO[dbo].[MonthlyTransaction]([Month],[EmployeeId] ,[Year],[TDC],[Fine],[SalaryInHand],[PfMonthly],[Memo],[AdvAmtSub],[PfLoanSub],[TransactionDate],[AbsentDays],[DaysInMonth],[Conv]) 
VALUES(@Month,@EmployeeId,@Year,@TDC,@Fine,@SalaryInHand,@PfMonthly,@Memo,@AdvAmtSub,@PfLoanSub,GetDate(),@Absent,@days,@Conv) 
INSERT INTO[dbo].[ArchiveTransactions] values(@EmployeeId, @EmployeeName, @Month, @Year, @PFloanWithdrawn, @PfLoanSub, @AdvanceAmt, @AdvAmtSub, @TDC, @Conv, @Fine, @Absent, @ActualSalary, @SalaryInHand, @Memo)
                    Insert into PfRecords VALUES(@EmployeeId,@PfLoanSub, @Month, @Year,1) 
                    Insert into PfRecords VALUES(@EmployeeId,@PfMonthly, @Month, @Year,2)
                    Insert into AdvanceRecords VALUES(@EmployeeId,@AdvAmtSub, @Month, @Year,1)";


                Save.Parameters.AddWithValue("@Month", comboBoxMonth.Text);

                Save.Parameters.AddWithValue("@EmployeeId", empId);
                Save.Parameters.AddWithValue("@EmployeeName", Ename.Text);
                Save.Parameters.AddWithValue("@Year", comboBoxYear.Text);
                Save.Parameters.AddWithValue("@TDC", txtTdc.Text);
                Save.Parameters.AddWithValue("@Fine", txtFine.Text);
                Save.Parameters.AddWithValue("@SalaryInHand", txtNetSalary.Text);
                Save.Parameters.AddWithValue("@Memo", richTextBoxMemo.Text);
                Save.Parameters.AddWithValue("@PFloanWithdrawn",RemaningPf);
                Save.Parameters.AddWithValue("@AdvanceAmt",RemaningAdv);
                Save.Parameters.AddWithValue("@AdvAmtSub", Convert.ToDouble(txtAAMD.Text));
                Save.Parameters.AddWithValue("@PfLoanSub", Convert.ToDouble(txtMPFLS.Text));
                Save.Parameters.AddWithValue("@Absent", txtAbsent.Text);
                Save.Parameters.AddWithValue("@PfMonthly", txtPF.Text);
                Save.Parameters.AddWithValue("@Conv", textBoxConv.Text);
                Save.Parameters.AddWithValue("@ActualSalary", textBoxConv.Text);
                int MonthS = Convert.ToInt32(comboBoxMonth.SelectedIndex.ToString());
                MonthS++;
                int YearS = Convert.ToInt32(comboBoxYear.SelectedItem.ToString());
                Save.Parameters.AddWithValue("@days", DateTime.DaysInMonth(YearS, MonthS));
                try
                {
                    DataManager.executeNonQuery(Save);
                }
                catch(SqlException Ex)
                {
                    if (Ex.Number == 2627)
                    {
                        MessageBox.Show("You Are Trying To save Duplicate records");
                        return;
                    }
                    else
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }

                Monthly_Transaction MT = new Monthly_Transaction();
                MT.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Cannot commit transaction as PF/Advance Amount Balance is insufficient");
            }
        }
       
        private void txtMonthlySalary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPF_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMPFLS_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAAMD_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFine_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTdc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNetSalary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Ename_Click(object sender, EventArgs e)
        {
            

        }

      

        private void btnCalcSalary_Click(object sender, EventArgs e)
        {
            double a;
            double Net=0;
            if (Ename.Text == null || Ename.Text == "")
            {
                MessageBox.Show("Please select employee");
                return;
            }
            if(comboBoxMonth.Text== null || comboBoxMonth.Text=="")
            {
                MessageBox.Show("Please select the month");
                return;
            }
            if (comboBoxYear.Text == null || comboBoxYear.Text == "")
            {
                MessageBox.Show("Please enter year");
                return;
            }
            if(txtMonthlySalary.Text==null||txtMonthlySalary.Text=="")
                {
                MessageBox.Show("Please enter Salary");
                return;
            }
            else
            {
                a = 0;
            }
            if(!(txtPF.Text == null || txtPF.Text == ""))
            {

                a = a + Convert.ToDouble(txtPF.Text);
            }
            if (!(txtAAMD.Text == null || txtAAMD.Text == ""))
            {

                a = a + Convert.ToDouble(txtAAMD.Text);
            }
            if (!(txtMPFLS.Text == null || txtMPFLS.Text == ""))
            {
              
                 a = a + Convert.ToDouble(txtMPFLS.Text);
            }
            if (!(txtTdc.Text == null || txtTdc.Text == ""))
            {

                a = a + Convert.ToDouble(txtTdc.Text);
            }
            if (!(txtFine.Text == null || txtFine.Text == ""))
            {

                a = a + Convert.ToDouble(txtFine.Text);
            }

            if (string.IsNullOrWhiteSpace(txtAbsent.Text))
            {
                Net = Convert.ToDouble(txtMonthlySalary.Text) - a;


            }

            else if (Convert.ToInt32(txtAbsent.Text) == 0)
            {
                Net = Convert.ToDouble(txtMonthlySalary.Text) - a;


            }

            else if (Convert.ToInt32(txtAbsent.Text) > 0)
            {
                int MonthS = Convert.ToInt32(comboBoxMonth.SelectedIndex.ToString());
                MonthS++;
                int YearS = Convert.ToInt32(comboBoxYear.SelectedItem.ToString());
                Int32 daysInMonth = System.DateTime.DaysInMonth(YearS, MonthS);
                double SalaryAbsentExc = Math.Truncate((float)Convert.ToInt32(txtMonthlySalary.Text) * ((float)daysInMonth - (float)Convert.ToInt32(txtAbsent.Text)) / (float)daysInMonth);
                SalaryAbsentExc = SalaryAbsentExc - a;
                Net = SalaryAbsentExc;
                

            }
            txtNetSalary.Text = Net.ToString();

        }

        private void txtAbsent_KeyPress(object sender, KeyPressEventArgs e)
        {
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
        }

        private void txtMonthlySalary_TextChanged(object sender, EventArgs e)
        { 
           double pfcalc= Convert.ToDouble(txtMonthlySalary.Text) * 0.12;
            
            if (pfcalc > 1800)
            {
                pfcalc = 1800;
            }
            txtPF.Text = pfcalc.ToString();
        }

        private void Ename_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNetSalary.Clear();
            if (flagload == false)
            { return; }
            try
            {
                SqlCommand cmd1 = new SqlCommand();

                cmd1.CommandText = "select * from employee where EmpName=@EmpName";
                cmd1.Parameters.AddWithValue("@EmpName", Ename.SelectedValue.ToString());

                DataSet DS1 = DataManager.executeDataset(cmd1);
                txtMonthlySalary.Text = DS1.Tables[0].Rows[0][5].ToString();
                txtMPFLS.Text = DS1.Tables[0].Rows[0][11].ToString();
                txtAAMD.Text = DS1.Tables[0].Rows[0][10].ToString();
             textBoxConv.Text=DS1.Tables[0].Rows[0][18].ToString();
                labelConvAmt.Text= DS1.Tables[0].Rows[0][18].ToString();
                var empId= DS1.Tables[0].Rows[0][0].ToString();
                SqlCommand Check = new SqlCommand();
                Check.CommandText = @"Select isnull(PFloanWithdrawn,0) from Employee  where empId=@EmpId
Select isnull(sum(PFAmount),0) from Pfrecords where eId=@EmpId and Flag=0
Select isnull(sum(PFAmount),0)from Pfrecords where eId=@EmpId and Flag=1
Select isnull(sum(PFAmount),0) from Pfrecords where eId=@EmpId and Flag=2
            Select isnull(AdvanceAmt,0) from Employee where empId=@EmpId
Select isnull(sum(AdvAmount),0) from AdvanceRecords where eId=@EmpId and Flag=0
Select isnull(sum(AdvAmount),0) from AdvanceRecords where eId=@EmpId and Flag=1";
                Check.Parameters.AddWithValue("@EmpId", empId);
                DataSet dsE = DataManager.executeDataset(Check);
                var OB = dsE.Tables[0].Rows[0][0].ToString();
                var Loan = dsE.Tables[1].Rows[0][0].ToString();
                var refund = dsE.Tables[2].Rows[0][0].ToString();
                var MonPf = dsE.Tables[3].Rows[0][0].ToString();
                var OB1 = dsE.Tables[4].Rows[0][0].ToString();
                var Loan1 = dsE.Tables[5].Rows[0][0].ToString();
                var refund1 = dsE.Tables[6].Rows[0][0].ToString();
                Double RemaningPf = Convert.ToDouble(Loan) - (Convert.ToDouble(refund) );
                Double RemaningAdv = Convert.ToDouble(Loan1) - Convert.ToDouble(refund1) ;
                labelPFAmtBal.Text = RemaningPf.ToString();
                lblAdvAmtBalance.Text = RemaningAdv.ToString();
                txtNetSalary.Text = "";

            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);

            }

        }

        private void dataGridViewMT_SelectionChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridViewMT.SelectedRows)
            {
             labelEmpId.Text = row.Cells[2].Value.ToString();
                labelMonth.Text = row.Cells[0].Value.ToString();
                labelYear.Text= row.Cells[1].Value.ToString();
                btnDelete.Visible = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this record.\n Note that it can affect the Other Amounts?",
                      "Continue", MessageBoxButtons.YesNo);
            switch (dr)
            {
                
                case DialogResult.No: break;
                
            }
            if (dr == DialogResult.Yes)
            {
                SqlCommand cmdDel = new SqlCommand();
                cmdDel.CommandText = @"Delete from MonthlyTransaction where EmployeeId=@EmployeeId and Month=@Month and Year=@Year
Delete from PFRecords where EId=@EmployeeId and Month=@Month and Year=@Year and Flag <>0
Delete from AdvanceRecords where EId=@EmployeeId and Month=@Month and Year=@Year and flag<>0
delete from archivetransactions  where EmployeeId=@EmployeeId and Month=@Month and Year=@Year";
                cmdDel.Parameters.AddWithValue("@EmployeeId",labelEmpId.Text);
                cmdDel.Parameters.AddWithValue("@Month", labelMonth.Text);
                cmdDel.Parameters.AddWithValue("@Year", labelYear.Text);
                int no= DataManager.executeNonQuery(cmdDel);
                if(no>=1)
                MessageBox.Show("Deleted successsfully");
                else
                MessageBox.Show("Something wrong Occured while performing delete");
                FillGrid();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string EmpName = txtEmpSearch.Text;
            string Month = comboBoxSMonth.Text;
            string Year= comboBoxSYear.Text;
            SqlCommand Fetch = new SqlCommand();
            Fetch.CommandText = @"select MT.Month,MT.Year,E.EmpId,MT.EmployeeId,E.EmpName,E.Department,
                E.SalaryPerMonth,MT.SalaryInHand,E.AdvanceAmt,E.PFloanWithdrawn,MT.TransactionDate,
            E.ConvPerMonth FRom Employee E join MonthlyTransaction MT ON E.EmpId=MT.EmployeeId
           where E.EmpName like '%" + EmpName + "%' and MT.Month Like '%" + Month + "%' and MT.Year like '%" + Year + "%' ORDER BY TRANSACTIONDATE ";
            try
            {
                SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(Fetch.CommandText, DataManager.connectionString);
                DataSet ds1 = new DataSet();
                dataadapter.Fill(ds1);

                dataGridViewMT.DataSource = ds1.Tables[0].DefaultView;
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            

            dataGridViewMT.Columns["EmpId"].Visible = false;
            dataGridViewMT.Columns["EmployeeId"].Visible = false;
            dataGridViewMT.Columns["TransactionDate"].Visible = false;
            dataGridViewMT.Columns["AdvanceAmt"].HeaderText = "Advance Amt Balance";
            dataGridViewMT.Columns["PFloanWithdrawn"].HeaderText = "PF Loan Balance";
            dataGridViewMT.Columns["SalaryPerMonth"].HeaderText = "Actual Salary";
            dataGridViewMT.Columns["EmpName"].HeaderText = "Name";
            btnDelete.Visible = false;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp eo = new Emp();
            eo.Show();
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

        private void txtAbsent_TextChanged(object sender, EventArgs e)
        {
            if (textBoxConv.Text == "" &&  comboBoxMonth.Text=="" && comboBoxYear.Text=="")
                return;
            else
            {
                if(txtAbsent.Text!=""&&txtAbsent.Text!="0")
                {

                
                int MonthS = Convert.ToInt32(comboBoxMonth.SelectedIndex.ToString());
                MonthS++;
                int YearS = Convert.ToInt32(comboBoxYear.SelectedItem.ToString());
                Int32 daysInMonth = System.DateTime.DaysInMonth(YearS, MonthS);
                var t= Convert.ToDouble(labelConvAmt.Text) / daysInMonth * (daysInMonth - Convert.ToInt32(txtAbsent.Text));
                textBoxConv.Text = t.ToString();
                }

            }
        }
    }
}
//http://csharp.net-informations.com/datagridview/csharp-datagridview-sql-server.htm