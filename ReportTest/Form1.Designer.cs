namespace ReportTest
{
    partial class LiquorForm
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
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.startTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.runRepBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(13, 49);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(73, 17);
            this.startTimeLabel.TabIndex = 0;
            this.startTimeLabel.Text = "Start Time";
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Location = new System.Drawing.Point(16, 143);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(68, 17);
            this.endTimeLabel.TabIndex = 1;
            this.endTimeLabel.Text = "End Time";
            // 
            // startTimePicker1
            // 
            this.startTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.startTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimePicker1.Location = new System.Drawing.Point(121, 49);
            this.startTimePicker1.Name = "startTimePicker1";
            this.startTimePicker1.ShowUpDown = true;
            this.startTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.startTimePicker1.TabIndex = 2;
            this.startTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startTimePicker1_MouseDown);
            // 
            // endTimePicker1
            // 
            this.endTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.endTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimePicker1.Location = new System.Drawing.Point(121, 137);
            this.endTimePicker1.Name = "endTimePicker1";
            this.endTimePicker1.ShowUpDown = true;
            this.endTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.endTimePicker1.TabIndex = 3;
            this.endTimePicker1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.endTimePicker1_MouseDown);
            // 
            // runRepBtn
            // 
            this.runRepBtn.Location = new System.Drawing.Point(121, 209);
            this.runRepBtn.Name = "runRepBtn";
            this.runRepBtn.Size = new System.Drawing.Size(75, 23);
            this.runRepBtn.TabIndex = 4;
            this.runRepBtn.Text = "Run Report";
            this.runRepBtn.UseVisualStyleBackColor = true;
            this.runRepBtn.Click += new System.EventHandler(this.runRepBtn_Click);
            // 
            // LiquorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 296);
            this.Controls.Add(this.runRepBtn);
            this.Controls.Add(this.endTimePicker1);
            this.Controls.Add(this.startTimePicker1);
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.startTimeLabel);
            this.Name = "LiquorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label endTimeLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker1;
        private System.Windows.Forms.DateTimePicker endTimePicker1;
        private System.Windows.Forms.Button runRepBtn;
    }
}

