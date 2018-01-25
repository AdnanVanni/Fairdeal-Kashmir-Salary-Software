﻿namespace Fairdeal_Kashmir_Salary_Software
{
    partial class Emp
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.labelParentage = new System.Windows.Forms.Label();
            this.labelResidence = new System.Windows.Forms.Label();
            this.labelJoinDate = new System.Windows.Forms.Label();
            this.labelEmpType = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textParentage = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textResidence = new System.Windows.Forms.TextBox();
            this.textDesignation = new System.Windows.Forms.TextBox();
            this.textAcc = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelDpt = new System.Windows.Forms.Label();
            this.listBoxEmpType = new System.Windows.Forms.ListBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelPFLoanWithdrawn = new System.Windows.Forms.Label();
            this.labelPFloanMonthlyDeduction = new System.Windows.Forms.Label();
            this.labelAdvAmt = new System.Windows.Forms.Label();
            this.labelAdvancedMonthlyDeduction = new System.Windows.Forms.Label();
            this.textMonthlySalary = new System.Windows.Forms.TextBox();
            this.textPFLW = new System.Windows.Forms.TextBox();
            this.textPFMD = new System.Windows.Forms.TextBox();
            this.textAACD = new System.Windows.Forms.TextBox();
            this.textAAMD = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMonthsTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(116, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.Location = new System.Drawing.Point(401, 224);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(64, 13);
            this.labelAccountNumber.TabIndex = 2;
            this.labelAccountNumber.Text = "Account No";
            // 
            // labelParentage
            // 
            this.labelParentage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParentage.AutoSize = true;
            this.labelParentage.Location = new System.Drawing.Point(116, 113);
            this.labelParentage.Name = "labelParentage";
            this.labelParentage.Size = new System.Drawing.Size(56, 13);
            this.labelParentage.TabIndex = 3;
            this.labelParentage.Text = "Parentage";
            // 
            // labelResidence
            // 
            this.labelResidence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResidence.AutoSize = true;
            this.labelResidence.Location = new System.Drawing.Point(401, 51);
            this.labelResidence.Name = "labelResidence";
            this.labelResidence.Size = new System.Drawing.Size(58, 13);
            this.labelResidence.TabIndex = 4;
            this.labelResidence.Text = "Residence";
            this.labelResidence.Click += new System.EventHandler(this.labelResidence_Click);
            // 
            // labelJoinDate
            // 
            this.labelJoinDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJoinDate.AutoSize = true;
            this.labelJoinDate.Location = new System.Drawing.Point(401, 84);
            this.labelJoinDate.Name = "labelJoinDate";
            this.labelJoinDate.Size = new System.Drawing.Size(52, 13);
            this.labelJoinDate.TabIndex = 5;
            this.labelJoinDate.Text = "Join Date";
            this.labelJoinDate.Click += new System.EventHandler(this.labelJoinDate_Click);
            // 
            // labelEmpType
            // 
            this.labelEmpType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmpType.AutoSize = true;
            this.labelEmpType.Location = new System.Drawing.Point(352, 120);
            this.labelEmpType.Name = "labelEmpType";
            this.labelEmpType.Size = new System.Drawing.Size(80, 13);
            this.labelEmpType.TabIndex = 6;
            this.labelEmpType.Text = "Employee Type";
            // 
            // labelDesignation
            // 
            this.labelDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(401, 183);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(63, 13);
            this.labelDesignation.TabIndex = 7;
            this.labelDesignation.Text = "Designation";
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(116, 142);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(116, 176);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtName.Location = new System.Drawing.Point(234, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 20);
            this.txtName.TabIndex = 10;
            // 
            // textParentage
            // 
            this.textParentage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textParentage.Location = new System.Drawing.Point(234, 113);
            this.textParentage.Name = "textParentage";
            this.textParentage.Size = new System.Drawing.Size(100, 20);
            this.textParentage.TabIndex = 12;
            // 
            // textPhone
            // 
            this.textPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPhone.Location = new System.Drawing.Point(234, 142);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 13;
            // 
            // textEmail
            // 
            this.textEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEmail.Location = new System.Drawing.Point(234, 176);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 14;
            // 
            // textResidence
            // 
            this.textResidence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResidence.Location = new System.Drawing.Point(486, 48);
            this.textResidence.Name = "textResidence";
            this.textResidence.Size = new System.Drawing.Size(100, 20);
            this.textResidence.TabIndex = 15;
            this.textResidence.TextChanged += new System.EventHandler(this.textResidence_TextChanged);
            // 
            // textDesignation
            // 
            this.textDesignation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDesignation.Location = new System.Drawing.Point(488, 183);
            this.textDesignation.Name = "textDesignation";
            this.textDesignation.Size = new System.Drawing.Size(100, 20);
            this.textDesignation.TabIndex = 18;
            this.textDesignation.TextChanged += new System.EventHandler(this.textDesignation_TextChanged);
            // 
            // textAcc
            // 
            this.textAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAcc.Location = new System.Drawing.Point(488, 221);
            this.textAcc.Name = "textAcc";
            this.textAcc.Size = new System.Drawing.Size(100, 20);
            this.textAcc.TabIndex = 19;
            this.textAcc.TextChanged += new System.EventHandler(this.textAcc_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(486, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 20;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelDpt
            // 
            this.labelDpt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDpt.AutoSize = true;
            this.labelDpt.Location = new System.Drawing.Point(114, 219);
            this.labelDpt.Name = "labelDpt";
            this.labelDpt.Size = new System.Drawing.Size(62, 13);
            this.labelDpt.TabIndex = 22;
            this.labelDpt.Text = "Department";
            // 
            // listBoxEmpType
            // 
            this.listBoxEmpType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEmpType.FormattingEnabled = true;
            this.listBoxEmpType.Items.AddRange(new object[] {
            "Salaried",
            "Contract",
            "Hourly"});
            this.listBoxEmpType.Location = new System.Drawing.Point(438, 124);
            this.listBoxEmpType.Name = "listBoxEmpType";
            this.listBoxEmpType.Size = new System.Drawing.Size(180, 43);
            this.listBoxEmpType.TabIndex = 23;
            this.listBoxEmpType.SelectedIndexChanged += new System.EventHandler(this.listBoxEmpType_SelectedIndexChanged);
            // 
            // labelSalary
            // 
            this.labelSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(114, 293);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(76, 13);
            this.labelSalary.TabIndex = 24;
            this.labelSalary.Text = "Monthly Salary";
            this.labelSalary.Click += new System.EventHandler(this.labelSalary_Click);
            // 
            // labelPFLoanWithdrawn
            // 
            this.labelPFLoanWithdrawn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPFLoanWithdrawn.AutoSize = true;
            this.labelPFLoanWithdrawn.Location = new System.Drawing.Point(116, 354);
            this.labelPFLoanWithdrawn.Name = "labelPFLoanWithdrawn";
            this.labelPFLoanWithdrawn.Size = new System.Drawing.Size(101, 13);
            this.labelPFLoanWithdrawn.TabIndex = 25;
            this.labelPFLoanWithdrawn.Text = "PF Loan Withdrawn";
            this.labelPFLoanWithdrawn.Click += new System.EventHandler(this.labelPFLoanWithdrawn_Click);
            // 
            // labelPFloanMonthlyDeduction
            // 
            this.labelPFloanMonthlyDeduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPFloanMonthlyDeduction.AutoSize = true;
            this.labelPFloanMonthlyDeduction.Location = new System.Drawing.Point(116, 415);
            this.labelPFloanMonthlyDeduction.Name = "labelPFloanMonthlyDeduction";
            this.labelPFloanMonthlyDeduction.Size = new System.Drawing.Size(139, 13);
            this.labelPFloanMonthlyDeduction.TabIndex = 26;
            this.labelPFloanMonthlyDeduction.Text = "PF Loan Monthly Deduction";
            this.labelPFloanMonthlyDeduction.Click += new System.EventHandler(this.labelPFloanMonthlyDeduction_Click);
            // 
            // labelAdvAmt
            // 
            this.labelAdvAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdvAmt.AutoSize = true;
            this.labelAdvAmt.Location = new System.Drawing.Point(412, 354);
            this.labelAdvAmt.Name = "labelAdvAmt";
            this.labelAdvAmt.Size = new System.Drawing.Size(174, 13);
            this.labelAdvAmt.TabIndex = 27;
            this.labelAdvAmt.Text = "Advanced Amount Current Balance";
            this.labelAdvAmt.Click += new System.EventHandler(this.labelAdvAmt_Click);
            // 
            // labelAdvancedMonthlyDeduction
            // 
            this.labelAdvancedMonthlyDeduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdvancedMonthlyDeduction.AutoSize = true;
            this.labelAdvancedMonthlyDeduction.Location = new System.Drawing.Point(412, 415);
            this.labelAdvancedMonthlyDeduction.Name = "labelAdvancedMonthlyDeduction";
            this.labelAdvancedMonthlyDeduction.Size = new System.Drawing.Size(187, 13);
            this.labelAdvancedMonthlyDeduction.TabIndex = 28;
            this.labelAdvancedMonthlyDeduction.Text = "Advanced Amount Monthly Deduction";
            this.labelAdvancedMonthlyDeduction.Click += new System.EventHandler(this.labelAdvancedMonthlyDeduction_Click);
            // 
            // textMonthlySalary
            // 
            this.textMonthlySalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textMonthlySalary.Location = new System.Drawing.Point(115, 318);
            this.textMonthlySalary.Name = "textMonthlySalary";
            this.textMonthlySalary.Size = new System.Drawing.Size(100, 20);
            this.textMonthlySalary.TabIndex = 29;
            this.textMonthlySalary.TextChanged += new System.EventHandler(this.textMonthlySalary_TextChanged);
            this.textMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMonthlySalary_KeyPress);
            // 
            // textPFLW
            // 
            this.textPFLW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPFLW.Location = new System.Drawing.Point(119, 380);
            this.textPFLW.Name = "textPFLW";
            this.textPFLW.Size = new System.Drawing.Size(100, 20);
            this.textPFLW.TabIndex = 30;
            this.textPFLW.TextChanged += new System.EventHandler(this.textPFLW_TextChanged);
            this.textPFLW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPFLW_KeyPress);
            // 
            // textPFMD
            // 
            this.textPFMD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPFMD.Location = new System.Drawing.Point(119, 448);
            this.textPFMD.Name = "textPFMD";
            this.textPFMD.Size = new System.Drawing.Size(100, 20);
            this.textPFMD.TabIndex = 31;
            this.textPFMD.TextChanged += new System.EventHandler(this.textPFMD_TextChanged);
            this.textPFMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPFMD_KeyPress);
            // 
            // textAACD
            // 
            this.textAACD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAACD.Location = new System.Drawing.Point(415, 380);
            this.textAACD.Name = "textAACD";
            this.textAACD.Size = new System.Drawing.Size(100, 20);
            this.textAACD.TabIndex = 32;
            this.textAACD.TextChanged += new System.EventHandler(this.textAACD_TextChanged);
            this.textAACD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAACD_KeyPress);
            // 
            // textAAMD
            // 
            this.textAAMD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAAMD.Location = new System.Drawing.Point(415, 448);
            this.textAAMD.Name = "textAAMD";
            this.textAAMD.Size = new System.Drawing.Size(100, 20);
            this.textAAMD.TabIndex = 33;
            this.textAAMD.TextChanged += new System.EventHandler(this.textAAMD_TextChanged);
            this.textAAMD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAAMD_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(488, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editEmployeeToolStripMenuItem,
            this.departmentsToolStripMenuItem,
            this.monthlyTransactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1315, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(112, 20);
            this.toolStripMenuItem1.Text = "                               ";
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.editEmployeeToolStripMenuItem.Text = " Employee";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDepartmentToolStripMenuItem});
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // addDepartmentToolStripMenuItem
            // 
            this.addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            this.addDepartmentToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addDepartmentToolStripMenuItem.Text = "Add Department";
            this.addDepartmentToolStripMenuItem.Click += new System.EventHandler(this.addDepartmentToolStripMenuItem_Click);
            // 
            // monthlyTransactionToolStripMenuItem
            // 
            this.monthlyTransactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMonthsTransactionToolStripMenuItem});
            this.monthlyTransactionToolStripMenuItem.Name = "monthlyTransactionToolStripMenuItem";
            this.monthlyTransactionToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.monthlyTransactionToolStripMenuItem.Text = "Monthly Transaction";
            // 
            // createMonthsTransactionToolStripMenuItem
            // 
            this.createMonthsTransactionToolStripMenuItem.Name = "createMonthsTransactionToolStripMenuItem";
            this.createMonthsTransactionToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.createMonthsTransactionToolStripMenuItem.Text = "Create Month\'sTransaction";
            this.createMonthsTransactionToolStripMenuItem.Click += new System.EventHandler(this.createMonthsTransactionToolStripMenuItem_Click);
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.AllowUserToAddRows = false;
            this.dataGridViewEmp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(673, 77);
            this.dataGridViewEmp.MinimumSize = new System.Drawing.Size(400, 400);
            this.dataGridViewEmp.MultiSelect = false;
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.Size = new System.Drawing.Size(630, 400);
            this.dataGridViewEmp.TabIndex = 36;
            this.dataGridViewEmp.SelectionChanged += new System.EventHandler(this.dataGridViewEmp_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(576, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(667, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(234, 216);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDept.TabIndex = 40;
            this.comboBoxDept.SelectedIndexChanged += new System.EventHandler(this.comboBoxDept_SelectedIndexChanged);
            // 
            // Emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1315, 733);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textAAMD);
            this.Controls.Add(this.textAACD);
            this.Controls.Add(this.textPFMD);
            this.Controls.Add(this.textPFLW);
            this.Controls.Add(this.textMonthlySalary);
            this.Controls.Add(this.labelAdvancedMonthlyDeduction);
            this.Controls.Add(this.labelAdvAmt);
            this.Controls.Add(this.labelPFloanMonthlyDeduction);
            this.Controls.Add(this.labelPFLoanWithdrawn);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.listBoxEmpType);
            this.Controls.Add(this.labelDpt);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textAcc);
            this.Controls.Add(this.textDesignation);
            this.Controls.Add(this.textResidence);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textParentage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.labelEmpType);
            this.Controls.Add(this.labelJoinDate);
            this.Controls.Add(this.labelResidence);
            this.Controls.Add(this.labelParentage);
            this.Controls.Add(this.labelAccountNumber);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Emp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Label labelParentage;
        private System.Windows.Forms.Label labelResidence;
        private System.Windows.Forms.Label labelJoinDate;
        private System.Windows.Forms.Label labelEmpType;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textParentage;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textResidence;
        private System.Windows.Forms.TextBox textDesignation;
        private System.Windows.Forms.TextBox textAcc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelDpt;
        private System.Windows.Forms.ListBox listBoxEmpType;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelPFLoanWithdrawn;
        private System.Windows.Forms.Label labelPFloanMonthlyDeduction;
        private System.Windows.Forms.Label labelAdvAmt;
        private System.Windows.Forms.Label labelAdvancedMonthlyDeduction;
        private System.Windows.Forms.TextBox textMonthlySalary;
        private System.Windows.Forms.TextBox textPFLW;
        private System.Windows.Forms.TextBox textPFMD;
        private System.Windows.Forms.TextBox textAACD;
        private System.Windows.Forms.TextBox textAAMD;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMonthsTransactionToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxDept;
    }
}

