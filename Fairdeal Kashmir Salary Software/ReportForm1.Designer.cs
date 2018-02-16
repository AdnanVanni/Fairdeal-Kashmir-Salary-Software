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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReport1 = new Fairdeal_Kashmir_Salary_Software.DataSetReport1();
            this.SalaryReportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalaryReportsTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetReport1TableAdapters.SalaryReportsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryReportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SalaryReportsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(69, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(515, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReport1
            // 
            this.DataSetReport1.DataSetName = "DataSetReport1";
            this.DataSetReport1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalaryReportsBindingSource
            // 
            this.SalaryReportsBindingSource.DataMember = "SalaryReports";
            this.SalaryReportsBindingSource.DataSource = this.DataSetReport1;
            // 
            // SalaryReportsTableAdapter
            // 
            this.SalaryReportsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 302);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportForm1";
            this.Text = "ReportForm1";
            this.Load += new System.EventHandler(this.ReportForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryReportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalaryReportsBindingSource;
        private DataSetReport1 DataSetReport1;
        private DataSetReport1TableAdapters.SalaryReportsTableAdapter SalaryReportsTableAdapter;
    }
}