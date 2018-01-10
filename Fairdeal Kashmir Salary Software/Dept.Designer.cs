namespace Fairdeal_Kashmir_Salary_Software
{
    partial class Dept
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
            this.txtDNmame = new System.Windows.Forms.TextBox();
            this.txtDLocation = new System.Windows.Forms.TextBox();
            this.labelFName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDNmame
            // 
            this.txtDNmame.Location = new System.Drawing.Point(285, 73);
            this.txtDNmame.Name = "txtDNmame";
            this.txtDNmame.Size = new System.Drawing.Size(100, 20);
            this.txtDNmame.TabIndex = 11;
            // 
            // txtDLocation
            // 
            this.txtDLocation.Location = new System.Drawing.Point(284, 119);
            this.txtDLocation.Name = "txtDLocation";
            this.txtDLocation.Size = new System.Drawing.Size(100, 20);
            this.txtDLocation.TabIndex = 12;
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(172, 76);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(91, 13);
            this.labelFName.TabIndex = 13;
            this.labelFName.Text = "Department name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Department Location";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(535, 297);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Dept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 332);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.txtDLocation);
            this.Controls.Add(this.txtDNmame);
            this.Name = "Dept";
            this.Text = "Dept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNmame;
        private System.Windows.Forms.TextBox txtDLocation;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
    }
}