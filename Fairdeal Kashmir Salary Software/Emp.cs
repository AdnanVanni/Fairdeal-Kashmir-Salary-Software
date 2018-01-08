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
    public partial class Emp : Form
    {
        public Emp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into employee values @EmpFname, @EmpLname, @AccNumber, @Department,@JoinDate,@SalaryPerMonth,@EmpType,@Designation,@AdvanceAmt,@PFloanWithdrawn,@MonthlyAdvAmountSubtracted],@MonthlyPFLoansubtracted,@Phone,@Email  ";

            
            cmd.Parameters.Add("Id", txtFNmame).Value = "00A640BD-1A0D-499D-9155-BA2B626D7B68";
            //cmd.Parameters.Add("AccountId", SqlDbType.NVarChar).Value = "DCBA241B-2B06-48D7-9AC1-6E277FBB1C2A";
            //cmd.Parameters.Add("FirstName", SqlDbType.NVarChar).Value = "Mark";
            //cmd.Parameters.Add("LastName", SqlDbType.NVarChar).Value = "Wahlberg";
            //cmd.Parameters.Add("JobTitle", SqlDbType.NVarChar).Value = "Actor";
            //cmd.Parameters.Add("PhoneNumber", SqlDbType.NVarChar).Value = "9889898989";

            return cmd.ExecuteNonQuery();
            SqlCommand cmd = new SqlCommand();
           cmd.CommandText= "select * from employee";
            DataManager.executeDataset(cmd);
            txtFNmame.Text = "done";

        }
    }
}
