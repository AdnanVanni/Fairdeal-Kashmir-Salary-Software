namespace Fairdeal_Kashmir_Salary_Software
{
    partial class PfForm
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
            this.PFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetPFF = new Fairdeal_Kashmir_Salary_Software.DataSetPFF();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewerPF = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PFTableAdapter = new Fairdeal_Kashmir_Salary_Software.DataSetPFFTableAdapters.PFTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPFF)).BeginInit();
            this.SuspendLayout();
            // 
            // PFBindingSource
            // 
            this.PFBindingSource.DataMember = "PF";
            this.PFBindingSource.DataSource = this.DataSetPFF;
            // 
            // DataSetPFF
            // 
            this.DataSetPFF.DataSetName = "DataSetPFF";
            this.DataSetPFF.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.comboBoxM.Location = new System.Drawing.Point(12, 96);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxM.TabIndex = 0;
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
            this.comboBoxY.Location = new System.Drawing.Point(139, 96);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(121, 21);
            this.comboBoxY.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewerPF
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PFBindingSource;
            this.reportViewerPF.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPF.LocalReport.ReportEmbeddedResource = "Fairdeal_Kashmir_Salary_Software.Report8.rdlc";
            this.reportViewerPF.Location = new System.Drawing.Point(20, 141);
            this.reportViewerPF.Name = "reportViewerPF";
            this.reportViewerPF.Size = new System.Drawing.Size(1327, 544);
            this.reportViewerPF.TabIndex = 4;
            // 
            // PFTableAdapter
            // 
            this.PFTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "<<<  HOME";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 780);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reportViewerPF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxM);
            this.Name = "PfForm";
            this.Text = "PfForm";
            this.Load += new System.EventHandler(this.PfForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetPFF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPF;
        private System.Windows.Forms.BindingSource PFBindingSource;
        private DataSetPFF DataSetPFF;
        private DataSetPFFTableAdapters.PFTableAdapter PFTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}