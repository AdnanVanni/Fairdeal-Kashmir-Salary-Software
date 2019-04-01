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
    public partial class SalaryBill_Total : MetroFramework.Forms.MetroForm
    {
        public SalaryBill_Total()
        {
            InitializeComponent();
        }

        private void SalaryBill_Total_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
