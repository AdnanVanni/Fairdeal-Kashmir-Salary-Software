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
    public partial class Dept : Form
    {
        public Dept()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (txtDNmame.Text == string.Empty)
            {
                MessageBox.Show("Please enter Department name");
                return;
            }
            else if (txtDLocation.Text == string.Empty)
            {
                MessageBox.Show("Please enter location of the department");
                return;
            }
            else
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into departments values(@DName,@DLocation)";
                cmd.Parameters.AddWithValue("@DName", txtDNmame.Text);
                cmd.Parameters.AddWithValue("@DLocation", txtDLocation.Text);
                DataManager.executeNonQuery(cmd);
            }
        }
    }
}
