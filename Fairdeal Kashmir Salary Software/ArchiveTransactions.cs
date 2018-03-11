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
    public partial class ArchiveTransactions : MetroFramework.Forms.MetroForm
    {
        public ArchiveTransactions()
        {
            InitializeComponent();
        }

        private void ArchiveTransactions_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            // TODO: This line of code loads data into the 'DataSetArchive.ArchiveTransactions' table. You can move, or remove it, as needed.

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.ArchiveTransactionsTableAdapter.Fill(this.DataSetArchive.ArchiveTransactions, comboBoxEmp.Text, comboBoxM.Text, comboBoxY.Text);
                this.reportViewer1.RefreshReport();
            }
            
                 catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp E = new Emp();
            E.Show();
            this.Hide();
        }
    }
    }
