namespace Fairdeal_Kashmir_Salary_Software
{
    partial class GeneralRecords
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.AllPFRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPFAllRecords = new Fairdeal_Kashmir_Salary_Software.DataSetPFAllRecords();
            this.AllAdvRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetAllAdv = new Fairdeal_Kashmir_Salary_Software.DataSetAllAdv();
            this.archBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetArch = new Fairdeal_Kashmir_Salary_Software.DataSetArch();
            this.buttonS = new System.Windows.Forms.Button();
            this.rvPf = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxEmp = new System.Windows.Forms.ComboBox();
            this.archTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetArchTableAdapters.archTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBoxM = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxY = new System.Windows.Forms.CheckedListBox();
            this.RVadv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.AllPFRecordsTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetPFAllRecordsTableAdapters.AllPFRecordsTableAdapter();
            this.DataSetCopyNot = new Fairdeal_Kashmir_Salary_Software.DataSetCopyNot();
            this.NotCopiedListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotCopiedListTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetCopyNotTableAdapters.NotCopiedListTableAdapter();
            this.AllAdvRecordsTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetAllAdvTableAdapters.AllAdvRecordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AllPFRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPFAllRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllAdvRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAllAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetArch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCopyNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotCopiedListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AllPFRecordsBindingSource
            // 
            this.AllPFRecordsBindingSource.DataMember = "AllPFRecords";
            this.AllPFRecordsBindingSource.DataSource = this.DataSetPFAllRecords;
            // 
            // DataSetPFAllRecords
            // 
            this.DataSetPFAllRecords.DataSetName = "DataSetPFAllRecords";
            this.DataSetPFAllRecords.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AllAdvRecordsBindingSource
            // 
            this.AllAdvRecordsBindingSource.DataMember = "AllAdvRecords";
            this.AllAdvRecordsBindingSource.DataSource = this.DataSetAllAdv;
            // 
            // DataSetAllAdv
            // 
            this.DataSetAllAdv.DataSetName = "DataSetAllAdv";
            this.DataSetAllAdv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(527, 85);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 24);
            this.buttonS.TabIndex = 59;
            this.buttonS.Text = "Search";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // rvPf
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.AllPFRecordsBindingSource;
            this.rvPf.LocalReport.DataSources.Add(reportDataSource3);
            this.rvPf.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report11.rdlc";
            this.rvPf.Location = new System.Drawing.Point(128, 112);
            this.rvPf.Name = "rvPf";
            this.rvPf.Size = new System.Drawing.Size(610, 625);
            this.rvPf.TabIndex = 58;
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
            this.comboBoxEmp.Location = new System.Drawing.Point(128, 85);
            this.comboBoxEmp.Name = "comboBoxEmp";
            this.comboBoxEmp.Size = new System.Drawing.Size(195, 21);
            this.comboBoxEmp.TabIndex = 55;
            // 
            // archTableAdapter
            // 
            this.archTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "<<<  HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(608, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 63;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBoxM
            // 
            this.checkedListBoxM.FormattingEnabled = true;
            this.checkedListBoxM.Items.AddRange(new object[] {
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
            this.checkedListBoxM.Location = new System.Drawing.Point(2, 85);
            this.checkedListBoxM.Name = "checkedListBoxM";
            this.checkedListBoxM.Size = new System.Drawing.Size(120, 184);
            this.checkedListBoxM.TabIndex = 64;
            // 
            // checkedListBoxY
            // 
            this.checkedListBoxY.FormattingEnabled = true;
            this.checkedListBoxY.Items.AddRange(new object[] {
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
            this.checkedListBoxY.Location = new System.Drawing.Point(2, 275);
            this.checkedListBoxY.Name = "checkedListBoxY";
            this.checkedListBoxY.Size = new System.Drawing.Size(120, 349);
            this.checkedListBoxY.TabIndex = 65;
            // 
            // RVadv
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.AllAdvRecordsBindingSource;
            this.RVadv.LocalReport.DataSources.Add(reportDataSource4);
            this.RVadv.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report12.rdlc";
            this.RVadv.Location = new System.Drawing.Point(744, 112);
            this.RVadv.Name = "RVadv";
            this.RVadv.Size = new System.Drawing.Size(620, 625);
            this.RVadv.TabIndex = 66;
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Items.AddRange(new object[] {
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
            this.comboBoxDept.Location = new System.Drawing.Point(329, 85);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(192, 21);
            this.comboBoxDept.TabIndex = 67;
            // 
            // AllPFRecordsTableAdapter
            // 
            this.AllPFRecordsTableAdapter.ClearBeforeFill = true;
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
            // AllAdvRecordsTableAdapter
            // 
            this.AllAdvRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // GeneralRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.RVadv);
            this.Controls.Add(this.checkedListBoxY);
            this.Controls.Add(this.checkedListBoxM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.rvPf);
            this.Controls.Add(this.comboBoxEmp);
            this.Controls.Add(this.button1);
            this.Name = "GeneralRecords";
            this.Text = "General Records";
            this.Load += new System.EventHandler(this.GeneralRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllPFRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPFAllRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllAdvRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetAllAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetArch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCopyNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotCopiedListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource archBindingSource;
        private DataSetArch DataSetArch;
        private System.Windows.Forms.Button buttonS;
        private Microsoft.Reporting.WinForms.ReportViewer rvPf;
        private System.Windows.Forms.ComboBox comboBoxEmp;
        private DataSetArchTableAdapters.archTableAdapter archTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBoxM;
        private System.Windows.Forms.CheckedListBox checkedListBoxY;
        private Microsoft.Reporting.WinForms.ReportViewer RVadv;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.BindingSource AllPFRecordsBindingSource;
        private DataSetPFAllRecords DataSetPFAllRecords;
        private DataSetPFAllRecordsTableAdapters.AllPFRecordsTableAdapter AllPFRecordsTableAdapter;
        private System.Windows.Forms.BindingSource NotCopiedListBindingSource;
        private DataSetCopyNot DataSetCopyNot;
        private DataSetCopyNotTableAdapters.NotCopiedListTableAdapter NotCopiedListTableAdapter;
        private System.Windows.Forms.BindingSource AllAdvRecordsBindingSource;
        private DataSetAllAdv DataSetAllAdv;
        private DataSetAllAdvTableAdapters.AllAdvRecordsTableAdapter AllAdvRecordsTableAdapter;
    }
}