namespace Fairdeal_Kashmir_Salary_Software
{
    partial class SumSalaryEmpYear
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.DataSetSUMsalary = new Fairdeal_Kashmir_Salary_Software.DataSetSUMsalary();
            this.SalaryBillSumYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalaryBillSumYearTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetSUMsalaryTableAdapters.SalaryBillSumYearTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSUMsalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBillSumYearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.SalaryBillSumYearBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.SalarySumYear.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1277, 600);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2017-18",
            "2018-19",
            "2019-20",
            "2020-21",
            "2021-22",
            "2022-23",
            "2023-24",
            "2024-25",
            "2025-26",
            "2026-27",
            "2027-28",
            "2028-29",
            "2029-30",
            "2030-31",
            "2031-32",
            "2032-34",
            "2033-34",
            "2034-35",
            "2035-36",
            "2036-37",
            "2037-38",
            "2038-39",
            "2039-40",
            "2040-41"});
            this.comboBoxYear.Location = new System.Drawing.Point(23, 94);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(160, 21);
            this.comboBoxYear.TabIndex = 1;
            // 
            // DataSetSUMsalary
            // 
            this.DataSetSUMsalary.DataSetName = "DataSetSUMsalary";
            this.DataSetSUMsalary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalaryBillSumYearBindingSource
            // 
            this.SalaryBillSumYearBindingSource.DataMember = "SalaryBillSumYear";
            this.SalaryBillSumYearBindingSource.DataSource = this.DataSetSUMsalary;
            // 
            // SalaryBillSumYearTableAdapter
            // 
            this.SalaryBillSumYearTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "<<<  HOME";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SumSalaryEmpYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 728);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SumSalaryEmpYear";
            this.Text = "Salary Sum Yearly";
            this.Load += new System.EventHandler(this.SumSalaryEmpYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSUMsalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBillSumYearBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.BindingSource SalaryBillSumYearBindingSource;
        private DataSetSUMsalary DataSetSUMsalary;
        private DataSetSUMsalaryTableAdapters.SalaryBillSumYearTableAdapter SalaryBillSumYearTableAdapter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button2;
    }
}