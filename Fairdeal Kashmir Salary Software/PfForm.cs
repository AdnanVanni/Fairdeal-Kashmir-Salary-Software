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
    public partial class PfForm : MetroFramework.Forms.MetroForm
    {
        public PfForm()
        {
            InitializeComponent();
        }

        private void PfForm_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxM.Text == "" || comboBoxY.Text == "" )
            {
                MessageBox.Show("Select Month and Year");
                return;
            }

        }
    }
}
