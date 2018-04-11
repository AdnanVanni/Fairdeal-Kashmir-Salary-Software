using System;
using System.Collections;
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
    public partial class GeneralRecords : MetroFramework.Forms.MetroForm
    {
        public GeneralRecords()
        {
            InitializeComponent();
        }

        private void GeneralRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetAllAdv.AllAdvRecords' table. You can move, or remove it, as needed.


            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            SqlCommand cmd15 = new SqlCommand();
            cmd15.CommandText = "select EmpName from employee order by EmpName ";
            DataSet DS1 = new DataSet();
            DS1 = DataManager.executeDataset(cmd15);


            comboBoxEmp.DataSource = DS1.Tables[0];
            comboBoxEmp.ValueMember = "EmpName";
            comboBoxEmp.DisplayMember = "EmpName";
            comboBoxEmp.SelectedItem = null;
            comboBoxEmp.SelectedText = null;

            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "SELECT * FROM Departments order by departmentName";
       
            DataSet dsD = new DataSet();
            dsD = DataManager.executeDataset(cmdd);
            comboBoxDept.DataSource = dsD.Tables[0];
            comboBoxDept.ValueMember = "DepartmentName";
            comboBoxDept.DisplayMember = "DepartmentName";
            comboBoxDept.SelectedItem = null;
            comboBoxDept.SelectedText = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp e3 = new Emp();
            e3.Show();
            this.Hide();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            string s = "";
            string T = "";
            if (checkedListBoxM.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select Month/s");
                return;
            }
            else
            {
                // If so, loop through all checked items and print results.  
                 s = "";
                for (int x = 0; x <= checkedListBoxM.CheckedItems.Count - 1; x++)
                {
                    if (s == "")
                    { s = s  + checkedListBoxM.CheckedItems[x].ToString(); }
                    else
                    s = s + ","+checkedListBoxM.CheckedItems[x].ToString();
                }
                
            }
            if (checkedListBoxM.CheckedItems.Count == 0)
            {
                MessageBox.Show("Select Year/s");
            }
            else
            {
                // If so, loop through all checked items and print results.  
                T = "";
                for (int x = 0; x <= checkedListBoxY.CheckedItems.Count - 1; x++)
                {
                    if (T == "")
                    { T = T + checkedListBoxY.CheckedItems[x].ToString(); }
                    else
                        T = T + "," + checkedListBoxY.CheckedItems[x].ToString() ;
                }
                
              


            }
            // TODO: This line of code loads data into the 'DataSetPFAllRecords.AllPFRecords' table. You can move, or remove it, as needed.
            this.AllPFRecordsTableAdapter.Fill(this.DataSetPFAllRecords.AllPFRecords,s.ToString(),T.ToString(),comboBoxEmp.Text,comboBoxDept.Text);
            this.rvPf.RefreshReport();

            this.AllAdvRecordsTableAdapter.Fill(this.DataSetAllAdv.AllAdvRecords, s, T, comboBoxEmp.Text, comboBoxDept.Text);
            this.RVadv.RefreshReport();


        }
     
    }
}
