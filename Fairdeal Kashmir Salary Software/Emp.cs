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
           cmd.CommandText= "select * from employee";
            DataManager.executeNonQuery(cmd);


        }
    }
}
