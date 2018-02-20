namespace Fairdeal_Kashmir_Salary_Software
{
    partial class ReportForm1
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
            this.SalaryReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReport1 = new Fairdeal_Kashmir_Salary_Software.DataSetReport1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SalaryReportsTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetReport1TableAdapters.SalaryReportsTableAdapter();
            this.comboBoxSYear = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxSMonth = new MetroFramework.Controls.MetroComboBox();
            this.Button1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryReportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport1)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryReportsBindingSource
            // 
            this.SalaryReportsBindingSource.DataMember = "SalaryReports";
            this.SalaryReportsBindingSource.DataSource = this.DataSetReport1;
            // 
            // DataSetReport1
            // 
            this.DataSetReport1.DataSetName = "DataSetReport1";
            this.DataSetReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalaryReportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1024, 570);
            this.reportViewer1.TabIndex = 0;
            // 
            // SalaryReportsTableAdapter
            // 
            this.SalaryReportsTableAdapter.ClearBeforeFill = true;
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
            this.comboBoxSYear.Location = new System.Drawing.Point(139, 48);
            this.comboBoxSYear.Name = "comboBoxSYear";
            this.comboBoxSYear.Size = new System.Drawing.Size(123, 29);
            this.comboBoxSYear.TabIndex = 44;
            this.comboBoxSYear.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.comboBoxSMonth.Location = new System.Drawing.Point(12, 48);
            this.comboBoxSMonth.Name = "comboBoxSMonth";
            this.comboBoxSMonth.Size = new System.Drawing.Size(121, 29);
            this.comboBoxSMonth.TabIndex = 45;
            this.comboBoxSMonth.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(268, 48);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(114, 29);
            this.Button1.TabIndex = 46;
            this.Button1.Text = "Preview Report";
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // ReportForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1162, 741);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.comboBoxSMonth);
            this.Controls.Add(this.comboBoxSYear);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm1";
            this.Text = "ReportForm1";
            this.Load += new System.EventHandler(this.ReportForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryReportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalaryReportsBindingSource;
        private DataSetReport1 DataSetReport1;
        private DataSetReport1TableAdapters.SalaryReportsTableAdapter SalaryReportsTableAdapter;
        private MetroFramework.Controls.MetroComboBox comboBoxSYear;
        private MetroFramework.Controls.MetroComboBox comboBoxSMonth;
        private MetroFramework.Controls.MetroButton Button1;
    }
}