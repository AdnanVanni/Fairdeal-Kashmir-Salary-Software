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
    public partial class RepoerForm2 : Form
    {
        public RepoerForm2()
        {
            InitializeComponent();
        }

        private void RepoerForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.SalaryBill' table. You can move, or remove it, as needed.
            

            SqlCommand cmdDept = new SqlCommand();
            cmdDept.CommandText = "SELECT DesignationName from Designation";
            DataSet DSdept = DataManager.executeDataset(cmdDept);
            ComboBoxDept.DataSource = DSdept.Tables[0];
            ComboBoxDept.ValueMember = "DesignationName";
            ComboBoxDept.DisplayMember = "DesignationName";
            ComboBoxDept.Text = "--Select--";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBoxSMonth.Text == "" || comboBoxSYear.Text == ""||ComboBoxDept.Text == "")
            {
               MessageBox.Show("Select Month and Year");
                return;
            }

            this.SalaryBillTableAdapter.Fill(this.DataSet2.SalaryBill, ComboBoxDept.Text, comboBoxSMonth.Text, comboBoxSYear.Text);
            
            
            this.reportViewer1.RefreshReport();
        }
    }
}
