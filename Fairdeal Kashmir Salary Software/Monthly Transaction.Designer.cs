namespace Fairdeal_Kashmir_Salary_Software
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
            this.SuspendLayout();
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.Location = new System.Drawing.Point(126, 310);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(27, 13);
            this.lblFine.TabIndex = 5;
            this.lblFine.Text = "Fine";
            // 
            // lblTdc
            // 
            this.lblTdc.AutoSize = true;
            this.lblTdc.Location = new System.Drawing.Point(126, 347);
            this.lblTdc.Name = "lblTdc";
            this.lblTdc.Size = new System.Drawing.Size(29, 13);
            this.lblTdc.TabIndex = 6;
            this.lblTdc.Text = "TDC";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(126, 111);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month";
            // 
            // lblEmployeeNamee
            // 
            this.lblEmployeeNamee.AutoSize = true;
            this.lblEmployeeNamee.Location = new System.Drawing.Point(126, 74);
            this.lblEmployeeNamee.Name = "lblEmployeeNamee";
            this.lblEmployeeNamee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployeeNamee.TabIndex = 8;
            this.lblEmployeeNamee.Text = "Employee";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(217, 307);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(121, 20);
            this.txtFine.TabIndex = 15;
            this.txtFine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFine_KeyPress);
            // 
            // txtTdc
            // 
            this.txtTdc.Location = new System.Drawing.Point(217, 340);
            this.txtTdc.Name = "txtTdc";
            this.txtTdc.Size = new System.Drawing.Size(121, 20);
            this.txtTdc.TabIndex = 16;
            this.txtTdc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTdc_KeyPress);
            // 
            // Ename
            // 
            this.Ename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ename.FormattingEnabled = true;
            this.Ename.Location = new System.Drawing.Point(217, 66);
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
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
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
            "",
            ""});
            this.comboBoxYear.Location = new System.Drawing.Point(307, 103);
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
            this.comboBoxMonth.Location = new System.Drawing.Point(217, 103);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(84, 21);
            this.comboBoxMonth.TabIndex = 20;
            // 
            // btnCalcSalary
            // 
            this.btnCalcSalary.Location = new System.Drawing.Point(128, 432);
            this.btnCalcSalary.Name = "btnCalcSalary";
            this.btnCalcSalary.Size = new System.Drawing.Size(130, 23);
            this.btnCalcSalary.TabIndex = 21;
            this.btnCalcSalary.Text = "Calculate Salary";
            this.btnCalcSalary.UseVisualStyleBackColor = true;
            this.btnCalcSalary.Click += new System.EventHandler(this.btnCalcSalary_Click);
            // 
            // lbLMPFLS
            // 
            this.lbLMPFLS.AutoSize = true;
            this.lbLMPFLS.Location = new System.Drawing.Point(126, 206);
            this.lbLMPFLS.Name = "lbLMPFLS";
            this.lbLMPFLS.Size = new System.Drawing.Size(132, 13);
            this.lbLMPFLS.TabIndex = 22;
            this.lbLMPFLS.Text = "PF Loan Month Deduction";
            // 
            // txtMPFLS
            // 
            this.txtMPFLS.Location = new System.Drawing.Point(217, 222);
            this.txtMPFLS.Name = "txtMPFLS";
            this.txtMPFLS.Size = new System.Drawing.Size(121, 20);
            this.txtMPFLS.TabIndex = 23;
            this.txtMPFLS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMPFLS_KeyPress);
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.Location = new System.Drawing.Point(291, 432);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.Size = new System.Drawing.Size(130, 20);
            this.txtNetSalary.TabIndex = 24;
            this.txtNetSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetSalary_KeyPress);
            // 
            // txtSaveRecord
            // 
            this.txtSaveRecord.Location = new System.Drawing.Point(478, 481);
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
            this.lblMemo.Location = new System.Drawing.Point(657, 55);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(64, 13);
            this.lblMemo.TabIndex = 27;
            this.lblMemo.Text = "Enter Memo";
            // 
            // richTextBoxMemo
            // 
            this.richTextBoxMemo.Location = new System.Drawing.Point(660, 86);
            this.richTextBoxMemo.Name = "richTextBoxMemo";
            this.richTextBoxMemo.Size = new System.Drawing.Size(217, 96);
            this.richTextBoxMemo.TabIndex = 28;
            this.richTextBoxMemo.Text = "";
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(217, 173);
            this.txtPF.Name = "txtPF";
            this.txtPF.Size = new System.Drawing.Size(121, 20);
            this.txtPF.TabIndex = 29;
            this.txtPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPF_KeyPress);
            // 
            // txtAAMD
            // 
            this.txtAAMD.Location = new System.Drawing.Point(217, 270);
            this.txtAAMD.Name = "txtAAMD";
            this.txtAAMD.Size = new System.Drawing.Size(121, 20);
            this.txtAAMD.TabIndex = 31;
            this.txtAAMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAAMD_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Advance Loan Month Deduction";
            // 
            // lblPFCalc
            // 
            this.lblPFCalc.AutoSize = true;
            this.lblPFCalc.Location = new System.Drawing.Point(126, 180);
            this.lblPFCalc.Name = "lblPFCalc";
            this.lblPFCalc.Size = new System.Drawing.Size(79, 13);
            this.lblPFCalc.TabIndex = 34;
            this.lblPFCalc.Text = "Provident Fund";
            // 
            // txtMonthlySalary
            // 
            this.txtMonthlySalary.Location = new System.Drawing.Point(217, 138);
            this.txtMonthlySalary.Name = "txtMonthlySalary";
            this.txtMonthlySalary.Size = new System.Drawing.Size(121, 20);
            this.txtMonthlySalary.TabIndex = 30;
            this.txtMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonthlySalary_KeyPress);
            // 
            // lblActualSalary
            // 
            this.lblActualSalary.AutoSize = true;
            this.lblActualSalary.Location = new System.Drawing.Point(126, 141);
            this.lblActualSalary.Name = "lblActualSalary";
            this.lblActualSalary.Size = new System.Drawing.Size(69, 13);
            this.lblActualSalary.TabIndex = 35;
            this.lblActualSalary.Text = "Actual Salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Absent Days";
            // 
            // txtAbsent
            // 
            this.txtAbsent.Location = new System.Drawing.Point(453, 138);
            this.txtAbsent.Name = "txtAbsent";
            this.txtAbsent.Size = new System.Drawing.Size(121, 20);
            this.txtAbsent.TabIndex = 37;
            this.txtAbsent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbsent_KeyPress);
            // 
            // Monthly_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 579);
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
    }
}