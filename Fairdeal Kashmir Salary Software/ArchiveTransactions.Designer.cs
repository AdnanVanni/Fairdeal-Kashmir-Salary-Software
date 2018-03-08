namespace Fairdeal_Kashmir_Salary_Software
{
    partial class ArchiveTransactions
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
            this.ArchiveTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetArchive = new Fairdeal_Kashmir_Salary_Software.DataSetArchive();
            this.ArchiveTransactionsTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetArchiveTableAdapters.ArchiveTransactionsTableAdapter();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.comboBoxEmp = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.ArchiveTransactionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(793, 260);
            this.reportViewer1.TabIndex = 0;
            // 
            // ArchiveTransactionsBindingSource
            // 
            this.ArchiveTransactionsBindingSource.DataMember = "ArchiveTransactions";
            this.ArchiveTransactionsBindingSource.DataSource = this.DataSetArchive;
            // 
            // DataSetArchive
            // 
            this.DataSetArchive.DataSetName = "DataSetArchive";
            this.DataSetArchive.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ArchiveTransactionsTableAdapter
            // 
            this.ArchiveTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxM
            // 
            this.comboBoxM.FormattingEnabled = true;
            this.comboBoxM.Items.AddRange(new object[] {
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
            this.comboBoxM.Location = new System.Drawing.Point(266, 29);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxM.TabIndex = 1;
            // 
            // comboBoxY
            // 
            this.comboBoxY.FormattingEnabled = true;
            this.comboBoxY.Items.AddRange(new object[] {
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
            this.comboBoxY.Location = new System.Drawing.Point(139, 29);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxY.TabIndex = 2;
            // 
            // comboBoxEmp
            // 
            this.comboBoxEmp.FormattingEnabled = true;
            this.comboBoxEmp.Location = new System.Drawing.Point(12, 29);
            this.comboBoxEmp.Name = "comboBoxEmp";
            this.comboBoxEmp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmp.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(393, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ArchiveTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 401);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxEmp);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ArchiveTransactions";
            this.Text = "ArchiveTransactions";
            this.Load += new System.EventHandler(this.ArchiveTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArchiveTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArchiveTransactionsBindingSource;
        private DataSetArchive DataSetArchive;
        private DataSetArchiveTableAdapters.ArchiveTransactionsTableAdapter ArchiveTransactionsTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.ComboBox comboBoxEmp;
        private System.Windows.Forms.Button btnSearch;
    }
}