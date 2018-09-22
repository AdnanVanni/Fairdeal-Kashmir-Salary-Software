namespace Fairdeal_Kashmir_Salary_Software
{
    partial class PfLoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PfLoan));
            this.comboBoxEmp = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblEmployeeNamee = new System.Windows.Forms.Label();
            this.txtPfLoan = new System.Windows.Forms.TextBox();
            this.lblPfLoan = new System.Windows.Forms.Label();
            this.dataGridViewMT = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelTT = new System.Windows.Forms.Label();
            this.comboBoxEmpS = new System.Windows.Forms.ComboBox();
            this.comboBoxM = new System.Windows.Forms.ComboBox();
            this.comboBoxY = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelEmp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEmp
            // 
            this.comboBoxEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEmp.FormattingEnabled = true;
            this.comboBoxEmp.Location = new System.Drawing.Point(127, 66);
            this.comboBoxEmp.Name = "comboBoxEmp";
            this.comboBoxEmp.Size = new System.Drawing.Size(174, 21);
            this.comboBoxEmp.TabIndex = 0;
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
            this.comboBoxMonth.Location = new System.Drawing.Point(127, 112);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(84, 21);
            this.comboBoxMonth.TabIndex = 23;
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
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.comboBoxYear.Location = new System.Drawing.Point(217, 112);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(84, 21);
            this.comboBoxYear.TabIndex = 22;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(44, 120);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(37, 13);
            this.lblMonth.TabIndex = 21;
            this.lblMonth.Text = "Month";
            // 
            // lblEmployeeNamee
            // 
            this.lblEmployeeNamee.AutoSize = true;
            this.lblEmployeeNamee.Location = new System.Drawing.Point(44, 74);
            this.lblEmployeeNamee.Name = "lblEmployeeNamee";
            this.lblEmployeeNamee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployeeNamee.TabIndex = 24;
            this.lblEmployeeNamee.Text = "Employee";
            // 
            // txtPfLoan
            // 
            this.txtPfLoan.Location = new System.Drawing.Point(127, 163);
            this.txtPfLoan.Name = "txtPfLoan";
            this.txtPfLoan.Size = new System.Drawing.Size(174, 20);
            this.txtPfLoan.TabIndex = 25;
            this.txtPfLoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPfLoan_KeyPress);
            // 
            // lblPfLoan
            // 
            this.lblPfLoan.AutoSize = true;
            this.lblPfLoan.Location = new System.Drawing.Point(47, 169);
            this.lblPfLoan.Name = "lblPfLoan";
            this.lblPfLoan.Size = new System.Drawing.Size(47, 13);
            this.lblPfLoan.TabIndex = 26;
            this.lblPfLoan.Text = "PF Loan";
            // 
            // dataGridViewMT
            // 
            this.dataGridViewMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMT.Location = new System.Drawing.Point(409, 63);
            this.dataGridViewMT.Name = "dataGridViewMT";
            this.dataGridViewMT.ReadOnly = true;
            this.dataGridViewMT.Size = new System.Drawing.Size(520, 621);
            this.dataGridViewMT.TabIndex = 27;
            this.dataGridViewMT.SelectionChanged += new System.EventHandler(this.dataGridViewMT_SelectionChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(854, 34);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelTT
            // 
            this.labelTT.AutoSize = true;
            this.labelTT.Location = new System.Drawing.Point(248, 283);
            this.labelTT.Name = "labelTT";
            this.labelTT.Size = new System.Drawing.Size(35, 13);
            this.labelTT.TabIndex = 30;
            this.labelTT.Text = "label1";
            this.labelTT.Visible = false;
            // 
            // comboBoxEmpS
            // 
            this.comboBoxEmpS.FormattingEnabled = true;
            this.comboBoxEmpS.Location = new System.Drawing.Point(409, 34);
            this.comboBoxEmpS.Name = "comboBoxEmpS";
            this.comboBoxEmpS.Size = new System.Drawing.Size(174, 21);
            this.comboBoxEmpS.TabIndex = 31;
            // 
            // comboBoxM
            // 
            this.comboBoxM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.comboBoxM.Location = new System.Drawing.Point(589, 34);
            this.comboBoxM.Name = "comboBoxM";
            this.comboBoxM.Size = new System.Drawing.Size(82, 21);
            this.comboBoxM.TabIndex = 34;
            // 
            // comboBoxY
            // 
            this.comboBoxY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            "2040",
            ""});
            this.comboBoxY.Location = new System.Drawing.Point(679, 34);
            this.comboBoxY.Name = "comboBoxY";
            this.comboBoxY.Size = new System.Drawing.Size(82, 21);
            this.comboBoxY.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(767, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(26, 21);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // labelEmp
            // 
            this.labelEmp.AutoSize = true;
            this.labelEmp.Location = new System.Drawing.Point(163, 315);
            this.labelEmp.Name = "labelEmp";
            this.labelEmp.Size = new System.Drawing.Size(50, 13);
            this.labelEmp.TabIndex = 47;
            this.labelEmp.Text = "labelEmp";
            this.labelEmp.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "<<<  HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PfLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 723);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelEmp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxM);
            this.Controls.Add(this.comboBoxY);
            this.Controls.Add(this.comboBoxEmpS);
            this.Controls.Add(this.labelTT);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewMT);
            this.Controls.Add(this.lblPfLoan);
            this.Controls.Add(this.txtPfLoan);
            this.Controls.Add(this.lblEmployeeNamee);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.comboBoxEmp);
            this.Name = "PfLoan";
            this.Text = "PF Loan";
            this.Load += new System.EventHandler(this.PfLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmp;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblEmployeeNamee;
        private System.Windows.Forms.TextBox txtPfLoan;
        private System.Windows.Forms.Label lblPfLoan;
        private System.Windows.Forms.DataGridView dataGridViewMT;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelTT;
        private System.Windows.Forms.ComboBox comboBoxEmpS;
        private System.Windows.Forms.ComboBox comboBoxM;
        private System.Windows.Forms.ComboBox comboBoxY;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelEmp;
        private System.Windows.Forms.Button button1;
    }
}