using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fairdeal_Kashmir_Salary_Software
{
    public partial class SalaryBill : MetroFramework.Forms.MetroForm
    {
        public SalaryBill()
        {
            InitializeComponent();
        }

        private void SalaryBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetSalaryBill.SalaryBill' table. You can move, or remove it, as needed.
this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            
            SqlCommand cmdDept = new SqlCommand();
            cmdDept.CommandText = "SELECT DepartmentName from Departments";
            DataSet DSdept = DataManager.executeDataset(cmdDept);
            comboBoxDept.DataSource = DSdept.Tables[0];
            comboBoxDept.ValueMember = "DepartmentName";
            comboBoxDept.DisplayMember = "DepartmentName";
            comboBoxDept.Text = "--Select--";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxM.Text == "" || comboBoxY.Text == "" || comboBoxDept.Text == "")
            {
                MessageBox.Show("Select Month and Year");
                return;
            }
            this.SalaryBillTableAdapter.Fill(this.DataSetSalaryBill.SalaryBill, comboBoxDept.Text, comboBoxM.Text, comboBoxY.Text);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emp emp1 = new Emp();
            emp1.Show();
            this.Hide();
        }
    }
}