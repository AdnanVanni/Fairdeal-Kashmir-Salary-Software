﻿namespace Fairdeal_Kashmir_Salary_Software
{
    partial class TransactionsArchived
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
            this.archBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetArch = new Fairdeal_Kashmir_Salary_Software.DataSetArch();
            this.comboBoxEmp = new System.Windows.Forms.ComboBox();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.buttonS = new System.Windows.Forms.Button();
            this.archTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetArchTableAdapters.archTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.archBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetArch)).BeginInit();
            this.SuspendLayout();
            // 
            // archBindingSource
            // 
            this.archBindingSource.DataMember = "arch";
            this.archBindingSource.DataSource = this.DataSetArch;
            // 
            // DataSetArch
            // 
            this.DataSetArch.DataSetName = "DataSetArch";
            this.DataSetArch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEmp
            // 
            this.comboBoxEmp.FormattingEnabled = true;
            this.comboBoxEmp.Items.AddRange(new object[] {
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
            this.comboBoxEmp.Location = new System.Drawing.Point(24, 82);
            this.comboBoxEmp.Name = "comboBoxEmp";
            this.comboBoxEmp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEmp.TabIndex = 0;
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
            this.comboBoxM.Location = new System.Drawing.Point(151, 82);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxM.TabIndex = 1;
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
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBoxY.Location = new System.Drawing.Point(278, 82);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxY.TabIndex = 2;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.archBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1189, 539);
            this.reportViewer1.TabIndex = 3;
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(405, 82);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 23);
            this.buttonS.TabIndex = 4;
            this.buttonS.Text = "Search";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // archTableAdapter
            // 
            this.archTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "<<<  HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
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
            this.checkedListBox1.Location = new System.Drawing.Point(501, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 199);
            this.checkedListBox1.TabIndex = 53;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
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
            this.checkedListBox2.Location = new System.Drawing.Point(636, 22);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 244);
            this.checkedListBox2.TabIndex = 54;
            // 
            // TransactionsArchived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 654);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.comboBoxEmp);
            this.Name = "TransactionsArchived";
            this.Text = "TransactionsArchived";
            this.Load += new System.EventHandler(this.TransactionsArchived_Load);
            ((System.ComponentModel.ISupportInitialize)(this.archBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetArch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmp;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.ComboBox comboBoxY;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.BindingSource archBindingSource;
        private DataSetArch DataSetArch;
        private DataSetArchTableAdapters.archTableAdapter archTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}