using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fairdeal_Kashmir_Salary_Software
{
    public partial class SumSalaryEmpYear : MetroFramework.Forms.MetroForm
    {
        public SumSalaryEmpYear()
        {
            InitializeComponent();
        }

        private void SumSalaryEmpYear_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxYear.Text == "") { MessageBox.Show("Select Year"); }
            // TODO: This line of code loads data into the 'DataSetSUMsalary.SalaryBillSumYear' table. You can move, or remove it, as needed.
           string  myString = comboBoxYear.Text.Substring(0, comboBoxYear.Text.Length - 3);
            this.SalaryBillSumYearTableAdapter.Fill(this.DataSetSUMsalary.SalaryBillSumYear,myString);

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
