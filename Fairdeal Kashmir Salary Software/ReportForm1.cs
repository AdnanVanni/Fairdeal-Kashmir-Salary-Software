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
    public partial class ReportForm1 : Form
    {
        public ReportForm1()
        {
            InitializeComponent();
        }

        private void ReportForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport1.SalaryReports' table. You can move, or remove it, as needed.
            //this.SalaryReportsTableAdapter.Fill(this.DataSetReport1.SalaryReports);
            //this.SalaryReportsTableAdapter.Fill(this.DataSetReport1.SalaryReports,"JANUARY","2018");

            //this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxSMonth.Text=="" || comboBoxSYear.Text=="")
            {
                MessageBox.Show("Select Month and Year");
                return;
            }
            
            this.SalaryReportsTableAdapter.Fill(this.DataSetReport1.SalaryReports, comboBoxSMonth.Text, comboBoxSYear.Text);
            

            this.reportViewer1.RefreshReport();

        }
    }
}
