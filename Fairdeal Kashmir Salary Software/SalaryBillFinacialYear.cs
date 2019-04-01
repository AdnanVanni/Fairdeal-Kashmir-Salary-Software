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
    public partial class SalaryBillFinacialYear : MetroFramework.Forms.MetroForm
    {
        public SalaryBillFinacialYear()
        {
            InitializeComponent();
        }

        private void SalaryBillFinacialYear_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

       
            if (comboBoxM.Text == "" ||comboBoxY.Text=="")
            {
                MessageBox.Show("Select Month and Year");
                return;
            }
            // TODO: This line of code loads data into the 'DataSetSalryBIllFinacialYear.SalaryBillSumFinancialYear' table. You can move, or remove it, as needed.
            string month = comboBoxM.Text;
            string Year = comboBoxY.Text;

            this.SalaryBillSumFinancialYearTableAdapter.Fill(this.DataSetSalryBIllFinacialYear.SalaryBillSumFinancialYear,Year, month);
            // TODO: This line of code loads data into the 'DataSetCopyNot.NotCopiedList' table. You can move, or remove it, as needed.

            
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp E = new Emp();
            E.Show();
            this.Hide();
        }
    }
}
