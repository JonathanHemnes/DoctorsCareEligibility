namespace DoctorsCareEligibility
{
    partial class Form1
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
            this.ImmigrationStatusLabel = new System.Windows.Forms.Label();
            this.usCitizenRadioButton = new System.Windows.Forms.RadioButton();
            this.lawFullyPresentRadioButton = new System.Windows.Forms.RadioButton();
            this.undocumentedRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ImmigrationStatusLabel
            // 
            this.ImmigrationStatusLabel.AutoSize = true;
            this.ImmigrationStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImmigrationStatusLabel.Location = new System.Drawing.Point(39, 29);
            this.ImmigrationStatusLabel.Name = "ImmigrationStatusLabel";
            this.ImmigrationStatusLabel.Size = new System.Drawing.Size(167, 24);
            this.ImmigrationStatusLabel.TabIndex = 0;
            this.ImmigrationStatusLabel.Text = "Immigration Status:";
            this.ImmigrationStatusLabel.Click += new System.EventHandler(this.ImmigrationStatusLabel_Click);
            // 
            // usCitizenRadioButton
            // 
            this.usCitizenRadioButton.AutoSize = true;
            this.usCitizenRadioButton.Location = new System.Drawing.Point(56, 77);
            this.usCitizenRadioButton.Name = "usCitizenRadioButton";
            this.usCitizenRadioButton.Size = new System.Drawing.Size(74, 17);
            this.usCitizenRadioButton.TabIndex = 1;
            this.usCitizenRadioButton.TabStop = true;
            this.usCitizenRadioButton.Text = "US Citizen";
            this.usCitizenRadioButton.UseVisualStyleBackColor = true;
            // 
            // lawFullyPresentRadioButton
            // 
            this.lawFullyPresentRadioButton.AutoSize = true;
            this.lawFullyPresentRadioButton.Location = new System.Drawing.Point(56, 100);
            this.lawFullyPresentRadioButton.Name = "lawFullyPresentRadioButton";
            this.lawFullyPresentRadioButton.Size = new System.Drawing.Size(102, 17);
            this.lawFullyPresentRadioButton.TabIndex = 2;
            this.lawFullyPresentRadioButton.TabStop = true;
            this.lawFullyPresentRadioButton.Text = "Lawfully Present";
            this.lawFullyPresentRadioButton.UseVisualStyleBackColor = true;
            // 
            // undocumentedRadioButton
            // 
            this.undocumentedRadioButton.AutoSize = true;
            this.undocumentedRadioButton.Location = new System.Drawing.Point(56, 123);
            this.undocumentedRadioButton.Name = "undocumentedRadioButton";
            this.undocumentedRadioButton.Size = new System.Drawing.Size(146, 17);
            this.undocumentedRadioButton.TabIndex = 3;
            this.undocumentedRadioButton.TabStop = true;
            this.undocumentedRadioButton.Text = "Undocumented Immigrant";
            this.undocumentedRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 638);
            this.Controls.Add(this.undocumentedRadioButton);
            this.Controls.Add(this.lawFullyPresentRadioButton);
            this.Controls.Add(this.usCitizenRadioButton);
            this.Controls.Add(this.ImmigrationStatusLabel);
            this.Name = "Form1";
            this.Text = "Doctors Care Eligibility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImmigrationStatusLabel;
        private System.Windows.Forms.RadioButton usCitizenRadioButton;
        private System.Windows.Forms.RadioButton lawFullyPresentRadioButton;
        private System.Windows.Forms.RadioButton undocumentedRadioButton;
    }
}

