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
    public partial class TransactionsArchived : MetroFramework.Forms.MetroForm
    {
        public TransactionsArchived()
        {
            InitializeComponent();
        }

        private void TransactionsArchived_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetArch.arch' table. You can move, or remove it, as needed.
            
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            SqlCommand cmd15 = new SqlCommand();
            cmd15.CommandText = "select EmpName from employee";
            DataSet DS1 = new DataSet();
            DS1 = DataManager.executeDataset(cmd15);


            comboBoxEmp.DataSource = DS1.Tables[0];
            comboBoxEmp.ValueMember = "EmpName";
            comboBoxEmp.DisplayMember = "EmpName";
            comboBoxEmp.SelectedIndex = -1;
           // this.reportViewer1.RefreshReport();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            try
            {
             this.archTableAdapter.Fill(this.DataSetArch.arch,comboBoxM.Text,comboBoxY.Text, comboBoxEmp.Text);
                this.reportViewer1.RefreshReport();
            }

            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp eo = new Emp();
            eo.Show();
            this.Hide();
        }
    }
}
