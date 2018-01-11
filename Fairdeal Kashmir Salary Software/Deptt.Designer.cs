namespace Fairdeal_Kashmir_Salary_Software
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
            this.labelDLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.TxtDLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDLocation
            // 
            this.labelDLocation.AutoSize = true;
            this.labelDLocation.Location = new System.Drawing.Point(180, 119);
            this.labelDLocation.Name = "labelDLocation";
            this.labelDLocation.Size = new System.Drawing.Size(48, 13);
            this.labelDLocation.TabIndex = 1;
            this.labelDLocation.Text = "Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department";
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(312, 73);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(167, 20);
            this.txtDName.TabIndex = 11;
            // 
            // TxtDLocation
            // 
            this.TxtDLocation.Location = new System.Drawing.Point(312, 112);
            this.TxtDLocation.Name = "TxtDLocation";
            this.TxtDLocation.Size = new System.Drawing.Size(167, 20);
            this.TxtDLocation.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Deptt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtDLocation);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDLocation);
            this.Name = "Deptt";
            this.Text = "Deptt";
            this.Load += new System.EventHandler(this.Deptt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox TxtDLocation;
        private System.Windows.Forms.Button button1;
    }
}