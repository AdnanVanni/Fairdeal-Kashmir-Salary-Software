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

            
            SqlCommand cmd15 = new SqlCommand();
            cmd15.CommandText = "select EmpName from employee";
            DataSet DS1 = new DataSet();
            DS1 = DataManager.executeDataset(cmd15);
            Ename.ValueMember = "EmpName";
            Ename.DisplayMember = "EmpName";
            Ename.DataSource = DS1.Tables[0];
            Ename.SelectedIndex = -1;
            txtAbsent.Text =Convert.ToString(0);

            Ename.Text = "--Select--";
            

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
        public void PopulateEmpComboBox()
        {
            

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
            SqlCommand GetEmp = new SqlCommand();
            GetEmp.CommandText = "select EmpId from Employee Where EmpName=@EmpName";
            GetEmp.Parameters.AddWithValue("@EmpName", Ename.SelectedValue);
            var empId = DataManager.executeScalar(GetEmp).ToString();
            //saves record in monthly transaction
            SqlCommand Save = new SqlCommand();
            Save.CommandText = "INSERT INTO[dbo].[MonthlyTransaction]([EmployeeId] ,[MonthYear] ,[TDC],[Fine],[SalaryInHand],[Memo]) VALUES(@EmployeeId,@MonthYear,@TDC,@Fine,@SalaryInHand,@Memo)";
            Save.Parameters.AddWithValue("@EmployeeId",empId);
            Save.Parameters.AddWithValue("@MonthYear",MonthYear);
            Save.Parameters.AddWithValue("@TDC",txtTdc.Text);
            Save.Parameters.AddWithValue("@Fine",txtFine.Text);
            Save.Parameters.AddWithValue("@SalaryInHand",txtNetSalary.Text);
            Save.Parameters.AddWithValue("@Memo",richTextBoxMemo.Text);
            DataManager.executeNonQuery(Save);
           
        }
        private void fillGrid()
        {
            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "SELECT * FROM MonthlyTransaction";
            SqlConnection connection1 = new SqlConnection(DataManager.connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(cmdd.CommandText, DataManager.connectionString);
            connection1.Open();
            DataSet ds1 = new DataSet();
            dataadapter.Fill(ds1, "Departments");
            connection1.Close();
            dataGridViewMT.DataSource = ds1;
            dataGridViewMT.DataMember = "Departments";
            dataGridViewMT.Columns[0].HeaderText = "Department Name/Location";
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
            if (Ename.SelectedIndex == -1)
            { return; }
            SqlCommand cmd1 = new SqlCommand();
            
            cmd1.CommandText = "select * from employee where EmpName=@EmpName";
            cmd1.Parameters.AddWithValue("@EmpName", Ename.SelectedValue.ToString());

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

            if (string.IsNullOrWhiteSpace(txtAbsent.Text))
            {
                int Net = Convert.ToInt32(txtMonthlySalary.Text) - a;
                txtNetSalary.Text = Net.ToString();
                return;
            }
           
            else if (Convert.ToInt32(txtAbsent.Text) == 0 )
            {
                int Net = Convert.ToInt32(txtMonthlySalary.Text) - a;
                txtNetSalary.Text = Net.ToString();
                return;
            }

                else if (Convert.ToInt32(txtAbsent.Text) > 0)
            {
                int MonthS = Convert.ToInt32(comboBoxMonth.SelectedIndex.ToString());
                MonthS++;
                int YearS = Convert.ToInt32(comboBoxYear.SelectedItem.ToString());
                Int32 daysInMonth = System.DateTime.DaysInMonth(YearS, MonthS);
                float SalaryAbsentExc = (float)Convert.ToInt32(txtMonthlySalary.Text) * ((float)daysInMonth - (float)Convert.ToInt32(txtAbsent.Text)) / (float)daysInMonth;
                SalaryAbsentExc = SalaryAbsentExc - a;
                txtNetSalary.Text = SalaryAbsentExc.ToString();
                return;
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