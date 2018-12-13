namespace WindowsFormsApp1
{
    partial class AddCall
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.callerName = new System.Windows.Forms.TextBox();
            this.callerCompany = new System.Windows.Forms.MaskedTextBox();
            this.callerPhone = new System.Windows.Forms.MaskedTextBox();
            this.askingFor = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.branch = new System.Windows.Forms.MaskedTextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(602, 149);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(312, 26);
            this.Date.TabIndex = 0;
            // 
            // Time
            // 
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time.Location = new System.Drawing.Point(602, 215);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(312, 26);
            this.Time.TabIndex = 1;
            // 
            // callerName
            // 
            this.callerName.Location = new System.Drawing.Point(602, 282);
            this.callerName.Name = "callerName";
            this.callerName.Size = new System.Drawing.Size(312, 26);
            this.callerName.TabIndex = 2;
            // 
            // callerCompany
            // 
            this.callerCompany.Location = new System.Drawing.Point(602, 348);
            this.callerCompany.Name = "callerCompany";
            this.callerCompany.Size = new System.Drawing.Size(312, 26);
            this.callerCompany.TabIndex = 3;
            // 
            // callerPhone
            // 
            this.callerPhone.Location = new System.Drawing.Point(602, 414);
            this.callerPhone.Name = "callerPhone";
            this.callerPhone.Size = new System.Drawing.Size(312, 26);
            this.callerPhone.TabIndex = 4;
            // 
            // askingFor
            // 
            this.askingFor.Location = new System.Drawing.Point(602, 480);
            this.askingFor.Name = "askingFor";
            this.askingFor.Size = new System.Drawing.Size(312, 26);
            this.askingFor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Caller Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Caller Company";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(374, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Caller Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Asking For";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 546);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Branch";
            // 
            // branch
            // 
            this.branch.Location = new System.Drawing.Point(602, 546);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(312, 26);
            this.branch.TabIndex = 13;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(748, 618);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(244, 83);
            this.submitBtn.TabIndex = 14;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(476, 618);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(244, 83);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // AddCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.branch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.askingFor);
            this.Controls.Add(this.callerPhone);
            this.Controls.Add(this.callerCompany);
            this.Controls.Add(this.callerName);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Date);
            this.Name = "AddCall";
            this.Size = new System.Drawing.Size(1761, 866);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.DateTimePicker Time;
        private System.Windows.Forms.TextBox callerName;
        private System.Windows.Forms.MaskedTextBox callerCompany;
        private System.Windows.Forms.MaskedTextBox callerPhone;
        private System.Windows.Forms.MaskedTextBox askingFor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox branch;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}
