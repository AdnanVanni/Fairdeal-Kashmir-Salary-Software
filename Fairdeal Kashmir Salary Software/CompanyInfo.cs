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
    public partial class CompanyInfo : MetroFramework.Forms.MetroForm
    {
        public CompanyInfo()
        {
            InitializeComponent();
        }

        private void btnCreateDb_Click(object sender, EventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand BCKUP = new SqlCommand();
                BCKUP.CommandText = "BACKUP DATABASE [Fairdeal db] TO DISK = 'E:\\Fairdeal db.Bak' WITH FORMAT,MEDIANAME = 'Z_SQLServerBackups',NAME = 'Full Backup of Fairdeal db';";

                DataManager.executeNonQuery(BCKUP);
                MessageBox.Show("Backup created in E:\\Fairdeal db.Bak");
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}         