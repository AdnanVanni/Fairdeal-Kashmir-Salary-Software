namespace Fairdeal_Kashmir_Salary_Software
{
    partial class RepoerForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalaryBillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Fairdeal_Kashmir_Salary_Software.DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxSMonth = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxSYear = new MetroFramework.Controls.MetroComboBox();
            this.Button1 = new MetroFramework.Controls.MetroButton();
            this.ComboBoxDept = new MetroFramework.Controls.MetroComboBox();
            this.SalaryBillTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSet2TableAdapters.SalaryBillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryBillBindingSource
            // 
            this.SalaryBillBindingSource.DataMember = "SalaryBill";
            this.SalaryBillBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.SalaryBillBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(569, 355);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboBoxSMonth
            // 
            this.comboBoxSMonth.FormattingEnabled = true;
            this.comboBoxSMonth.ItemHeight = 23;
            this.comboBoxSMonth.Items.AddRange(new object[] {
            "JANUARY",
            "FEBRUARY",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUGUST",
            "SEPTEMBER",
            "OCTOBER",
            "NOVEMBER",
            "DECEMBER"});
            this.comboBoxSMonth.Location = new System.Drawing.Point(139, 59);
            this.comboBoxSMonth.Name = "comboBoxSMonth";
            this.comboBoxSMonth.Size = new System.Drawing.Size(121, 29);
            this.comboBoxSMonth.TabIndex = 46;
            this.comboBoxSMonth.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // comboBoxSYear
            // 
            this.comboBoxSYear.FormattingEnabled = true;
            this.comboBoxSYear.ItemHeight = 23;
            this.comboBoxSYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBoxSYear.Location = new System.Drawing.Point(266, 59);
            this.comboBoxSYear.Name = "comboBoxSYear";
            this.comboBoxSYear.Size = new System.Drawing.Size(123, 29);
            this.comboBoxSYear.TabIndex = 47;
            this.comboBoxSYear.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(395, 59);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(114, 29);
            this.Button1.TabIndex = 48;
            this.Button1.Text = "Preview Report";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ComboBoxDept
            // 
            this.ComboBoxDept.FormattingEnabled = true;
            this.ComboBoxDept.ItemHeight = 23;
            this.ComboBoxDept.Location = new System.Drawing.Point(12, 59);
            this.ComboBoxDept.Name = "ComboBoxDept";
            this.ComboBoxDept.Size = new System.Drawing.Size(121, 29);
            this.ComboBoxDept.TabIndex = 49;
            // 
            // SalaryBillTableAdapter
            // 
            this.SalaryBillTableAdapter.ClearBeforeFill = true;
            // 
            // RepoerForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 477);
            this.Controls.Add(this.ComboBoxDept);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.comboBoxSYear);
            this.Controls.Add(this.comboBoxSMonth);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RepoerForm2";
            this.Text = "RepoerForm2";
            this.Load += new System.EventHandler(this.RepoerForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroComboBox comboBoxSMonth;
        private MetroFramework.Controls.MetroComboBox comboBoxSYear;
        private MetroFramework.Controls.MetroButton Button1;
        private MetroFramework.Controls.MetroComboBox ComboBoxDept;
        private System.Windows.Forms.BindingSource SalaryBillBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.SalaryBillTableAdapter SalaryBillTableAdapter;
    }
}