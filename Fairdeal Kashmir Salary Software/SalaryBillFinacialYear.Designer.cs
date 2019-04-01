namespace Fairdeal_Kashmir_Salary_Software
{
    partial class SalaryBillFinacialYear
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
            this.SalaryBillSumFinancialYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetSalryBIllFinacialYear = new Fairdeal_Kashmir_Salary_Software.DataSetSalryBIllFinacialYear();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetCopyNot = new Fairdeal_Kashmir_Salary_Software.DataSetCopyNot();
            this.NotCopiedListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotCopiedListTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetCopyNotTableAdapters.NotCopiedListTableAdapter();
            this.SalaryBillSumFinancialYearTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetSalryBIllFinacialYearTableAdapters.SalaryBillSumFinancialYearTableAdapter();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBillSumFinancialYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSalryBIllFinacialYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCopyNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotCopiedListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryBillSumFinancialYearBindingSource
            // 
            this.SalaryBillSumFinancialYearBindingSource.DataMember = "SalaryBillSumFinancialYear";
            this.SalaryBillSumFinancialYearBindingSource.DataSource = this.DataSetSalryBIllFinacialYear;
            // 
            // DataSetSalryBIllFinacialYear
            // 
            this.DataSetSalryBIllFinacialYear.DataSetName = "DataSetSalryBIllFinacialYear";
            this.DataSetSalryBIllFinacialYear.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetFY";
            reportDataSource1.Value = this.SalaryBillSumFinancialYearBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report13.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(33, 114);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1292, 584);
            this.reportViewer1.TabIndex = 1;
            // 
            // DataSetCopyNot
            // 
            this.DataSetCopyNot.DataSetName = "DataSetCopyNot";
            this.DataSetCopyNot.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NotCopiedListBindingSource
            // 
            this.NotCopiedListBindingSource.DataMember = "NotCopiedList";
            this.NotCopiedListBindingSource.DataSource = this.DataSetCopyNot;
            // 
            // NotCopiedListTableAdapter
            // 
            this.NotCopiedListTableAdapter.ClearBeforeFill = true;
            // 
            // SalaryBillSumFinancialYearTableAdapter
            // 
            this.SalaryBillSumFinancialYearTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(287, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 64;
            this.button1.Text = "<<<  HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Items.AddRange(new object[] {
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
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBoxY.Location = new System.Drawing.Point(160, 87);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxY.TabIndex = 66;
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Items.AddRange(new object[] {
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
            this.comboBoxM.Location = new System.Drawing.Point(33, 87);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxM.TabIndex = 65;
            // 
            // SalaryBillFinacialYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.reportViewer1);
            this.Name = "SalaryBillFinacialYear";
            this.Text = "Salary Bill Finacial Year";
            this.Load += new System.EventHandler(this.SalaryBillFinacialYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBillSumFinancialYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSalryBIllFinacialYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCopyNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotCopiedListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NotCopiedListBindingSource;
        private DataSetCopyNot DataSetCopyNot;
        private DataSetCopyNotTableAdapters.NotCopiedListTableAdapter NotCopiedListTableAdapter;
        private System.Windows.Forms.BindingSource SalaryBillSumFinancialYearBindingSource;
        private DataSetSalryBIllFinacialYear DataSetSalryBIllFinacialYear;
        private DataSetSalryBIllFinacialYearTableAdapters.SalaryBillSumFinancialYearTableAdapter SalaryBillSumFinancialYearTableAdapter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.ComboBox comboBoxM;
    }
}