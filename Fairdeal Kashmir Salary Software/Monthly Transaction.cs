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
    public partial class Monthly_Transaction : Form
    {
        public Monthly_Transaction()
        {
            InitializeComponent();
        }

        private void Monthly_Transaction_Load(object sender, EventArgs e)
        {
           
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            PopulateEmpComboBox();
            Ename.SelectedIndex = -1;
            const int JANUARY = 1;
            const int FEBRUARY = 2;
            const int MARCH = 3;
            const int APRIL = 4;
            const int MAY = 5;
            const int JUNE = 6;
            const int JULY = 7;
            const int AUGUST = 8;
            const int SEPTEMBER = 9;
            const int OCTOBER = 10;
            const int NOVEMBER = 11;
            const int DECEMBER = 12;
        }
        private void PopulateEmpComboBox()
        {
            SqlCommand cmd15 = new SqlCommand();
            cmd15.CommandText = "select EmpId,EmpName from employee";
            DataSet DS1 = new DataSet();
               DS1= DataManager.executeDataset(cmd15);
            Ename.DisplayMember = "EmpName";
            Ename.ValueMember = "EmpId";
            Ename.DataSource = DS1.Tables[0];
            
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
            string MonthYear = comboBoxMonth.Text + comboBoxYear.Text;
            SqlCommand Save = new SqlCommand();
            Save.CommandText = "INSERT INTO[dbo].[MonthlyTransaction]([EmployeeName] ,[MonthYear] ,[TDC],[Fine],[SalaryInHand],[Memo]) VALUES(@EmployeeName,@MonthYear,@TDC,@Fine,@SalaryInHand,@Memo)";
            Save.Parameters.AddWithValue("@EmployeeName",Ename.SelectedText);
            Save.Parameters.AddWithValue("@MonthYear",MonthYear);
            Save.Parameters.AddWithValue("@TDC",txtTdc.Text);
            Save.Parameters.AddWithValue("@Fine",txtFine.Text);
            Save.Parameters.AddWithValue("@SalaryInHand",txtNetSalary.Text);
            Save.Parameters.AddWithValue("@Memo",richTextBoxMemo.Text);
            DataManager.executeNonQuery(Save);

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

        private void Ename_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "select * from employee where EmpName='adnan'";
            cmd1.Parameters.AddWithValue("@EmpName", Ename.SelectedValue);

            DataSet DS1 = DataManager.executeDataset(cmd1);
            txtMonthlySalary.Text = DS1.Tables[0].Rows[0][5].ToString();
            txtMPFLS.Text = DS1.Tables[0].Rows[0][10].ToString();
            txtAAMD.Text = DS1.Tables[0].Rows[0][11].ToString();
        }

        private void btnCalcSalary_Click(object sender, EventArgs e)
        {
            int a;

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

                a = a + Convert.ToInt32(txtPF.Text);
            }
            if (!(txtAAMD.Text == null || txtAAMD.Text == ""))
            {

                a = a + Convert.ToInt32(txtAAMD.Text);
            }
            if (!(txtMPFLS.Text == null || txtMPFLS.Text == ""))
            {
              
                 a = a + Convert.ToInt32(txtMPFLS.Text);
            }
            if (!(txtTdc.Text == null || txtTdc.Text == ""))
            {

                a = a + Convert.ToInt32(txtTdc.Text);
            }
            if (!(txtFine.Text == null || txtFine.Text == ""))
            {

                a = a + Convert.ToInt32(txtFine.Text);
            }
            if (Convert.ToUInt32(txtAbsent) > 0 && txtAbsent.Text != "")
            {
                int daysInMonth = System.DateTime.DaysInMonth(Convert.ToInt32(comboBoxYear.SelectedText), Convert.ToInt32(comboBoxMonth.SelectedIndex));
                int SalaryAbsentExc = Convert.ToInt32(txtMonthlySalary) * (daysInMonth - Convert.ToInt32(txtAbsent) / daysInMonth);
                txtNetSalary.Text = SalaryAbsentExc.ToString();
            }
            else
            {
                txtNetSalary.Text = txtMonthlySalary.Text;
            }
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
            txtPF.Text = pfcalc.ToString();
        }
    }
}
//http://csharp.net-informations.com/datagridview/csharp-datagridview-sql-server.htm