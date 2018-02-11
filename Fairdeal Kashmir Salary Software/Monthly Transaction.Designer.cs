﻿namespace Fairdeal_Kashmir_Salary_Software
{
    partial class Monthly_Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monthly_Transaction));
            this.lblFine = new System.Windows.Forms.Label();
            this.lblTdc = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblEmployeeNamee = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtTdc = new System.Windows.Forms.TextBox();
            this.Ename = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.btnCalcSalary = new System.Windows.Forms.Button();
            this.lbLMPFLS = new System.Windows.Forms.Label();
            this.txtMPFLS = new System.Windows.Forms.TextBox();
            this.txtNetSalary = new System.Windows.Forms.TextBox();
            this.txtSaveRecord = new System.Windows.Forms.Button();
            this.lblMemo = new System.Windows.Forms.Label();
            this.richTextBoxMemo = new System.Windows.Forms.RichTextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtAAMD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPFCalc = new System.Windows.Forms.Label();
            this.txtMonthlySalary = new System.Windows.Forms.TextBox();
            this.lblActualSalary = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAbsent = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewMT = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxSMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxSYear = new System.Windows.Forms.ComboBox();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.labelEmpId = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(32, 307);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(27, 13);
            this.lblFine.TabIndex = 5;
            this.lblFine.Text = "Fine";
            // 
            // lblTdc
            // 
            this.lblTdc.AutoSize = true;
            this.lblTdc.Location = new System.Drawing.Point(32, 343);
            this.lblTdc.Name = "lblTdc";
            this.lblTdc.Size = new System.Drawing.Size(29, 13);
            this.lblTdc.TabIndex = 6;
            this.lblTdc.Text = "TDC";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(32, 111);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month";
            // 
            // lblEmployeeNamee
            // 
            this.lblEmployeeNamee.AutoSize = true;
            this.lblEmployeeNamee.Location = new System.Drawing.Point(32, 74);
            this.lblEmployeeNamee.Name = "lblEmployeeNamee";
            this.lblEmployeeNamee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployeeNamee.TabIndex = 8;
            this.lblEmployeeNamee.Text = "Employee";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(129, 307);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(121, 20);
            this.txtFine.TabIndex = 15;
            this.txtFine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFine_KeyPress);
            // 
            // txtTdc
            // 
            this.txtTdc.Location = new System.Drawing.Point(128, 340);
            this.txtTdc.Name = "txtTdc";
            this.txtTdc.Size = new System.Drawing.Size(121, 20);
            this.txtTdc.TabIndex = 16;
            this.txtTdc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTdc_KeyPress);
            // 
            // Ename
            // 
            this.Ename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ename.FormattingEnabled = true;
            this.Ename.Location = new System.Drawing.Point(128, 71);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(121, 21);
            this.Ename.TabIndex = 18;
            this.Ename.SelectedIndexChanged += new System.EventHandler(this.Ename_SelectedIndexChanged);
            this.Ename.Click += new System.EventHandler(this.Ename_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
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
            "2040",
            ""});
            this.comboBoxYear.Location = new System.Drawing.Point(219, 103);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(84, 21);
            this.comboBoxYear.TabIndex = 19;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
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
            this.comboBoxMonth.Location = new System.Drawing.Point(129, 103);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(84, 21);
            this.comboBoxMonth.TabIndex = 20;
            // 
            // btnCalcSalary
            // 
            this.btnCalcSalary.Location = new System.Drawing.Point(129, 432);
            this.btnCalcSalary.Name = "btnCalcSalary";
            this.btnCalcSalary.Size = new System.Drawing.Size(121, 23);
            this.btnCalcSalary.TabIndex = 21;
            this.btnCalcSalary.Text = "Calculate Salary";
            this.btnCalcSalary.UseVisualStyleBackColor = true;
            this.btnCalcSalary.Click += new System.EventHandler(this.btnCalcSalary_Click);
            // 
            // lbLMPFLS
            // 
            this.lbLMPFLS.AutoSize = true;
            this.lbLMPFLS.Location = new System.Drawing.Point(32, 207);
            this.lbLMPFLS.Name = "lbLMPFLS";
            this.lbLMPFLS.Size = new System.Drawing.Size(132, 13);
            this.lbLMPFLS.TabIndex = 22;
            this.lbLMPFLS.Text = "PF Loan Month Deduction";
            // 
            // txtMPFLS
            // 
            this.txtMPFLS.Location = new System.Drawing.Point(129, 223);
            this.txtMPFLS.Name = "txtMPFLS";
            this.txtMPFLS.Size = new System.Drawing.Size(121, 20);
            this.txtMPFLS.TabIndex = 23;
            this.txtMPFLS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMPFLS_KeyPress);
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.Location = new System.Drawing.Point(273, 434);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.Size = new System.Drawing.Size(130, 20);
            this.txtNetSalary.TabIndex = 24;
            this.txtNetSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetSalary_KeyPress);
            // 
            // txtSaveRecord
            // 
            this.txtSaveRecord.Location = new System.Drawing.Point(273, 503);
            this.txtSaveRecord.Name = "txtSaveRecord";
            this.txtSaveRecord.Size = new System.Drawing.Size(130, 23);
            this.txtSaveRecord.TabIndex = 25;
            this.txtSaveRecord.Text = "Save Record";
            this.txtSaveRecord.UseVisualStyleBackColor = true;
            this.txtSaveRecord.Click += new System.EventHandler(this.txtSaveRecord_Click);
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(282, 254);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(64, 13);
            this.lblMemo.TabIndex = 27;
            this.lblMemo.Text = "Enter Memo";
            // 
            // richTextBoxMemo
            // 
            this.richTextBoxMemo.Location = new System.Drawing.Point(285, 270);
            this.richTextBoxMemo.Name = "richTextBoxMemo";
            this.richTextBoxMemo.Size = new System.Drawing.Size(217, 96);
            this.richTextBoxMemo.TabIndex = 28;
            this.richTextBoxMemo.Text = "";
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(129, 173);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(121, 20);
            this.txtPF.TabIndex = 29;
            this.txtPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPF_KeyPress);
            // 
            // txtAAMD
            // 
            this.txtAAMD.Location = new System.Drawing.Point(128, 270);
            this.txtAAMD.Name = "txtAAMD";
            this.txtAAMD.Size = new System.Drawing.Size(121, 20);
            this.txtAAMD.TabIndex = 31;
            this.txtAAMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAAMD_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Advance Loan Month Deduction";
            // 
            // lblPFCalc
            // 
            this.lblPFCalc.AutoSize = true;
            this.lblPFCalc.Location = new System.Drawing.Point(32, 176);
            this.lblPFCalc.Name = "lblPFCalc";
            this.lblPFCalc.Size = new System.Drawing.Size(79, 13);
            this.lblPFCalc.TabIndex = 34;
            this.lblPFCalc.Text = "Provident Fund";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Location = new System.Drawing.Point(129, 138);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.Size = new System.Drawing.Size(121, 20);
            this.txtMonthlySalary.TabIndex = 30;
            this.txtMonthlySalary.TextChanged += new System.EventHandler(this.txtMonthlySalary_TextChanged);
            this.txtMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonthlySalary_KeyPress);
            // 
            // lblActualSalary
            // 
            this.lblActualSalary.AutoSize = true;
            this.lblActualSalary.Location = new System.Drawing.Point(32, 141);
            this.lblActualSalary.Name = "lblActualSalary";
            this.lblActualSalary.Size = new System.Drawing.Size(69, 13);
            this.lblActualSalary.TabIndex = 35;
            this.lblActualSalary.Text = "Actual Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Absent Days";
            // 
            // txtAbsent
            // 
            this.txtAbsent.Location = new System.Drawing.Point(352, 145);
            this.txtAbsent.Name = "txtAbsent";
            this.txtAbsent.Size = new System.Drawing.Size(121, 20);
            this.txtAbsent.TabIndex = 37;
            this.txtAbsent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbsent_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewMT
            // 
            this.dataGridViewMT.AllowUserToAddRows = false;
            this.dataGridViewMT.AllowUserToDeleteRows = false;
            this.dataGridViewMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMT.Location = new System.Drawing.Point(559, 83);
            this.dataGridViewMT.MultiSelect = false;
            this.dataGridViewMT.Name = "dataGridViewMT";
            this.dataGridViewMT.Size = new System.Drawing.Size(724, 501);
            this.dataGridViewMT.TabIndex = 38;
            this.dataGridViewMT.SelectionChanged += new System.EventHandler(this.dataGridViewMT_SelectionChanged);
            // 
            // comboBoxSMonth
            // 
            this.comboBoxSMonth.FormattingEnabled = true;
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
            this.comboBoxSMonth.Location = new System.Drawing.Point(559, 56);
            this.comboBoxSMonth.Name = "comboBoxSMonth";
            this.comboBoxSMonth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSMonth.TabIndex = 39;
            // 
            // comboBoxSYear
            // 
            this.comboBoxSYear.FormattingEnabled = true;
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
            "2040",
            ""});
            this.comboBoxSYear.Location = new System.Drawing.Point(686, 56);
            this.comboBoxSYear.Name = "comboBoxSYear";
            this.comboBoxSYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSYear.TabIndex = 40;
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Location = new System.Drawing.Point(813, 56);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(121, 20);
            this.txtEmpSearch.TabIndex = 41;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(933, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 21);
            this.btnSearch.TabIndex = 45;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1132, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 23);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete Selected Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // labelEmpId
            // 
            this.labelEmpId.AutoSize = true;
            this.labelEmpId.Location = new System.Drawing.Point(49, 553);
            this.labelEmpId.Name = "labelEmpId";
            this.labelEmpId.Size = new System.Drawing.Size(38, 13);
            this.labelEmpId.TabIndex = 47;
            this.labelEmpId.Text = "labelId";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(118, 552);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(38, 13);
            this.labelMonth.TabIndex = 48;
            this.labelMonth.Text = "labelM";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(981, 56);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Text = "button1";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(186, 551);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(36, 13);
            this.labelYear.TabIndex = 50;
            this.labelYear.Text = "labelY";
            // 
            // Monthly_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 617);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelEmpId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtEmpSearch);
            this.Controls.Add(this.comboBoxSYear);
            this.Controls.Add(this.comboBoxSMonth);
            this.Controls.Add(this.dataGridViewMT);
            this.Controls.Add(this.txtAbsent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblActualSalary);
            this.Controls.Add(this.lblPFCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAAMD);
            this.Controls.Add(this.txtMonthlySalary);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.richTextBoxMemo);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.txtSaveRecord);
            this.Controls.Add(this.txtNetSalary);
            this.Controls.Add(this.txtMPFLS);
            this.Controls.Add(this.lbLMPFLS);
            this.Controls.Add(this.btnCalcSalary);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.Ename);
            this.Controls.Add(this.txtTdc);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.lblEmployeeNamee);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblTdc);
            this.Controls.Add(this.lblFine);
            this.Name = "Monthly_Transaction";
            this.Text = "Monthly_Transaction";
            this.Load += new System.EventHandler(this.Monthly_Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblTdc;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblEmployeeNamee;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.TextBox txtTdc;
        private System.Windows.Forms.ComboBox Ename;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button btnCalcSalary;
        private System.Windows.Forms.Label lbLMPFLS;
        private System.Windows.Forms.TextBox txtMPFLS;
        private System.Windows.Forms.TextBox txtNetSalary;
        private System.Windows.Forms.Button txtSaveRecord;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.RichTextBox richTextBoxMemo;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtAAMD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPFCalc;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.Label lblActualSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAbsent;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewMT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxSMonth;
        private System.Windows.Forms.ComboBox comboBoxSYear;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label labelEmpId;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelYear;
    }
}