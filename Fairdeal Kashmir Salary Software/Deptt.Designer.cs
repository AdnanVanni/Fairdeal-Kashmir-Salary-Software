﻿namespace Fairdeal_Kashmir_Salary_Software
{
    partial class Deptt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridViewDeptt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDep = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeptt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(136, 122);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(246, 20);
            this.txtDName.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 169);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridViewDeptt
            // 
            this.dataGridViewDeptt.AllowUserToAddRows = false;
            this.dataGridViewDeptt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewDeptt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDeptt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeptt.Location = new System.Drawing.Point(548, 59);
            this.dataGridViewDeptt.MultiSelect = false;
            this.dataGridViewDeptt.Name = "dataGridViewDeptt";
            this.dataGridViewDeptt.Size = new System.Drawing.Size(283, 608);
            this.dataGridViewDeptt.TabIndex = 14;
            this.dataGridViewDeptt.SelectionChanged += new System.EventHandler(this.dataGridViewDeptt_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, -17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 17;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDep.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDep.Location = new System.Drawing.Point(14, 26);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(123, 25);
            this.lblDep.TabIndex = 18;
            this.lblDep.Text = "Departments";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "<<<  HOME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deptt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 780);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDeptt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.label1);
            this.DisplayHeader = false;
            this.Name = "Deptt";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "Deptt";
            this.Load += new System.EventHandler(this.Deptt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeptt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridViewDeptt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroLabel lblDep;
        private System.Windows.Forms.Button button1;
    }
}