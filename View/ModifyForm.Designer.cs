namespace View
{
    partial class ModifyForm
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
            this.groupBoxModifyPerson = new System.Windows.Forms.GroupBox();
            this.buttonCalculateSalary = new System.Windows.Forms.Button();
            this.buttonОК = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxModifyPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxModifyPerson
            // 
            this.groupBoxModifyPerson.Controls.Add(this.buttonCalculateSalary);
            this.groupBoxModifyPerson.Location = new System.Drawing.Point(29, 23);
            this.groupBoxModifyPerson.Name = "groupBoxModifyPerson";
            this.groupBoxModifyPerson.Size = new System.Drawing.Size(906, 364);
            this.groupBoxModifyPerson.TabIndex = 0;
            this.groupBoxModifyPerson.TabStop = false;
            this.groupBoxModifyPerson.Text = "ModifyPerson";
            // 
            // buttonCalculateSalary
            // 
            this.buttonCalculateSalary.Location = new System.Drawing.Point(12, 321);
            this.buttonCalculateSalary.Name = "buttonCalculateSalary";
            this.buttonCalculateSalary.Size = new System.Drawing.Size(150, 30);
            this.buttonCalculateSalary.TabIndex = 25;
            this.buttonCalculateSalary.Text = "Calculate Salary";
            this.buttonCalculateSalary.UseVisualStyleBackColor = true;
            this.buttonCalculateSalary.Click += new System.EventHandler(this.buttonCalculateSalary_Click);
            // 
            // buttonОК
            // 
            this.buttonОК.Location = new System.Drawing.Point(297, 446);
            this.buttonОК.Name = "buttonОК";
            this.buttonОК.Size = new System.Drawing.Size(75, 23);
            this.buttonОК.TabIndex = 27;
            this.buttonОК.Text = "OK";
            this.buttonОК.UseVisualStyleBackColor = true;
            this.buttonОК.Click += new System.EventHandler(this.buttonОК_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(440, 446);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(69, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 501);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonОК);
            this.Controls.Add(this.groupBoxModifyPerson);
            this.Name = "ModifyForm";
            this.Text = "PersonForm";
            this.groupBoxModifyPerson.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxModifyPerson;
        private System.Windows.Forms.Button buttonCalculateSalary;
        private System.Windows.Forms.Button buttonОК;
        private System.Windows.Forms.Button buttonCancel;
    }
}