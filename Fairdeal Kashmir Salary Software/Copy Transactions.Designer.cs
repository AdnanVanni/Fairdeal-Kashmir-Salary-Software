namespace Fairdeal_Kashmir_Salary_Software
{
    partial class Copy_Transactions
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
            this.copyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCopy = new Fairdeal_Kashmir_Salary_Software.DataSetCopy();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMonthFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxYearFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxMonthTo = new System.Windows.Forms.ComboBox();
            this.comboBoxYearTo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCpy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.copyTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetCopyTableAdapters.copyTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.copyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCopy)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyBindingSource
            // 
            this.copyBindingSource.DataMember = "copy";
            this.copyBindingSource.DataSource = this.DataSetCopy;
            // 
            // DataSetCopy
            // 
            this.DataSetCopy.DataSetName = "DataSetCopy";
            this.DataSetCopy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copy Transactions From";
            // 
            // comboBoxMonthFrom
            // 
            this.comboBoxMonthFrom.FormattingEnabled = true;
            this.comboBoxMonthFrom.Items.AddRange(new object[] {
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
            this.comboBoxMonthFrom.Location = new System.Drawing.Point(156, 6);
            this.comboBoxMonthFrom.Name = "comboBoxMonthFrom";
            this.comboBoxMonthFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonthFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // comboBoxYearFrom
            // 
            this.comboBoxYearFrom.FormattingEnabled = true;
            this.comboBoxYearFrom.Items.AddRange(new object[] {
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
            this.comboBoxYearFrom.Location = new System.Drawing.Point(283, 6);
            this.comboBoxYearFrom.Name = "comboBoxYearFrom";
            this.comboBoxYearFrom.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYearFrom.TabIndex = 3;
            // 
            // comboBoxMonthTo
            // 
            this.comboBoxMonthTo.FormattingEnabled = true;
            this.comboBoxMonthTo.Items.AddRange(new object[] {
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
            this.comboBoxMonthTo.Location = new System.Drawing.Point(156, 52);
            this.comboBoxMonthTo.Name = "comboBoxMonthTo";
            this.comboBoxMonthTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonthTo.TabIndex = 4;
            // 
            // comboBoxYearTo
            // 
            this.comboBoxYearTo.FormattingEnabled = true;
            this.comboBoxYearTo.Items.AddRange(new object[] {
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
            this.comboBoxYearTo.Location = new System.Drawing.Point(283, 52);
            this.comboBoxYearTo.Name = "comboBoxYearTo";
            this.comboBoxYearTo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYearTo.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCpy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxYearTo);
            this.panel1.Controls.Add(this.comboBoxMonthFrom);
            this.panel1.Controls.Add(this.comboBoxMonthTo);
            this.panel1.Controls.Add(this.comboBoxYearFrom);
            this.panel1.Location = new System.Drawing.Point(59, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 146);
            this.panel1.TabIndex = 6;
            // 
            // btnCpy
            // 
            this.btnCpy.Location = new System.Drawing.Point(254, 101);
            this.btnCpy.Name = "btnCpy";
            this.btnCpy.Size = new System.Drawing.Size(58, 23);
            this.btnCpy.TabIndex = 6;
            this.btnCpy.Text = "Copy";
            this.btnCpy.UseVisualStyleBackColor = true;
            this.btnCpy.Click += new System.EventHandler(this.btnCpy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(-242, -162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SELECT THE MONTH FROM WHICH  YOU WANT TO COPY TRANSACTIONS";
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.Location = new System.Drawing.Point(59, 261);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(139, 199);
            this.listBoxEmployees.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(56, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "FOLLOWING EMPLOYEES\' TRANSACTIONS WERE NOT COPIED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(532, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Month to be copied from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(532, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Month to be copied to";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.copyBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(258, 261);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(219, 246);
            this.reportViewer1.TabIndex = 12;
            // 
            // copyTableAdapter
            // 
            this.copyTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "<<<  HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Copy_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "Copy_Transactions";
            this.Text = "Copy Transactions";
            this.Load += new System.EventHandler(this.Copy_Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.copyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCopy)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMonthFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxYearFrom;
        private System.Windows.Forms.ComboBox comboBoxMonthTo;
        private System.Windows.Forms.ComboBox comboBoxYearTo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCpy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource copyBindingSource;
        private DataSetCopy DataSetCopy;
        private DataSetCopyTableAdapters.copyTableAdapter copyTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}