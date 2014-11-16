﻿namespace DoctorsCareEligibility
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
            this.yearsPresentLabel = new System.Windows.Forms.Label();
            this.yearsPresentTextBox = new System.Windows.Forms.TextBox();
            this.fiveYearExemptCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfFamilyMemberstextBox1 = new System.Windows.Forms.TextBox();
            this.doesNotHaveChildrenCheckBox = new System.Windows.Forms.CheckBox();
            this.isPregnantCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hasChild0to5CheckBox = new System.Windows.Forms.CheckBox();
            this.hasChild5to6CheckBox = new System.Windows.Forms.CheckBox();
            this.hasChild6to12CheckBox = new System.Windows.Forms.CheckBox();
            this.hasChild13to18CheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.personalInfoTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eligibleProgramsTabPage = new System.Windows.Forms.TabPage();
            this.getMatchesButton = new System.Windows.Forms.Button();
            this.programDescriptionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eligibleProgramsListBox = new System.Windows.Forms.ListBox();
            this.personalInfoTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.eligibleProgramsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImmigrationStatusLabel
            // 
            this.ImmigrationStatusLabel.AutoSize = true;
            this.ImmigrationStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImmigrationStatusLabel.Location = new System.Drawing.Point(6, 3);
            this.ImmigrationStatusLabel.Name = "ImmigrationStatusLabel";
            this.ImmigrationStatusLabel.Size = new System.Drawing.Size(162, 24);
            this.ImmigrationStatusLabel.TabIndex = 0;
            this.ImmigrationStatusLabel.Text = "Immigration Status";
            this.ImmigrationStatusLabel.Click += new System.EventHandler(this.ImmigrationStatusLabel_Click);
            // 
            // usCitizenRadioButton
            // 
            this.usCitizenRadioButton.AutoSize = true;
            this.usCitizenRadioButton.Location = new System.Drawing.Point(37, 30);
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
            this.lawFullyPresentRadioButton.Location = new System.Drawing.Point(37, 53);
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
            this.undocumentedRadioButton.Location = new System.Drawing.Point(37, 76);
            this.undocumentedRadioButton.Name = "undocumentedRadioButton";
            this.undocumentedRadioButton.Size = new System.Drawing.Size(146, 17);
            this.undocumentedRadioButton.TabIndex = 3;
            this.undocumentedRadioButton.TabStop = true;
            this.undocumentedRadioButton.Text = "Undocumented Immigrant";
            this.undocumentedRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearsPresentLabel
            // 
            this.yearsPresentLabel.AutoSize = true;
            this.yearsPresentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsPresentLabel.Location = new System.Drawing.Point(291, 3);
            this.yearsPresentLabel.Name = "yearsPresentLabel";
            this.yearsPresentLabel.Size = new System.Drawing.Size(292, 24);
            this.yearsPresentLabel.TabIndex = 4;
            this.yearsPresentLabel.Text = "Years Present In the United States";
            // 
            // yearsPresentTextBox
            // 
            this.yearsPresentTextBox.Location = new System.Drawing.Point(315, 29);
            this.yearsPresentTextBox.Name = "yearsPresentTextBox";
            this.yearsPresentTextBox.Size = new System.Drawing.Size(97, 20);
            this.yearsPresentTextBox.TabIndex = 5;
            // 
            // fiveYearExemptCheckBox
            // 
            this.fiveYearExemptCheckBox.AutoSize = true;
            this.fiveYearExemptCheckBox.Location = new System.Drawing.Point(315, 55);
            this.fiveYearExemptCheckBox.Name = "fiveYearExemptCheckBox";
            this.fiveYearExemptCheckBox.Size = new System.Drawing.Size(142, 17);
            this.fiveYearExemptCheckBox.TabIndex = 6;
            this.fiveYearExemptCheckBox.Text = "Exempt from 5 year limit?";
            this.fiveYearExemptCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Family Members";
            // 
            // numberOfFamilyMemberstextBox1
            // 
            this.numberOfFamilyMemberstextBox1.Location = new System.Drawing.Point(37, 139);
            this.numberOfFamilyMemberstextBox1.Name = "numberOfFamilyMemberstextBox1";
            this.numberOfFamilyMemberstextBox1.Size = new System.Drawing.Size(97, 20);
            this.numberOfFamilyMemberstextBox1.TabIndex = 8;
            // 
            // doesNotHaveChildrenCheckBox
            // 
            this.doesNotHaveChildrenCheckBox.AutoSize = true;
            this.doesNotHaveChildrenCheckBox.Location = new System.Drawing.Point(37, 228);
            this.doesNotHaveChildrenCheckBox.Name = "doesNotHaveChildrenCheckBox";
            this.doesNotHaveChildrenCheckBox.Size = new System.Drawing.Size(136, 17);
            this.doesNotHaveChildrenCheckBox.TabIndex = 11;
            this.doesNotHaveChildrenCheckBox.Text = "Does not have children";
            this.doesNotHaveChildrenCheckBox.UseVisualStyleBackColor = true;
            this.doesNotHaveChildrenCheckBox.CheckedChanged += new System.EventHandler(this.doesNotHaveChildrenCheckBox_CheckedChanged);
            // 
            // isPregnantCheckBox
            // 
            this.isPregnantCheckBox.AutoSize = true;
            this.isPregnantCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPregnantCheckBox.Location = new System.Drawing.Point(37, 251);
            this.isPregnantCheckBox.Name = "isPregnantCheckBox";
            this.isPregnantCheckBox.Size = new System.Drawing.Size(69, 17);
            this.isPregnantCheckBox.TabIndex = 12;
            this.isPregnantCheckBox.Text = "Pregnant";
            this.isPregnantCheckBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.isPregnantCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ages of children";
            // 
            // hasChild0to5CheckBox
            // 
            this.hasChild0to5CheckBox.AutoSize = true;
            this.hasChild0to5CheckBox.Location = new System.Drawing.Point(37, 274);
            this.hasChild0to5CheckBox.Name = "hasChild0to5CheckBox";
            this.hasChild0to5CheckBox.Size = new System.Drawing.Size(47, 17);
            this.hasChild0to5CheckBox.TabIndex = 14;
            this.hasChild0to5CheckBox.Text = "0 - 5";
            this.hasChild0to5CheckBox.UseVisualStyleBackColor = true;
            // 
            // hasChild5to6CheckBox
            // 
            this.hasChild5to6CheckBox.AutoSize = true;
            this.hasChild5to6CheckBox.Location = new System.Drawing.Point(37, 297);
            this.hasChild5to6CheckBox.Name = "hasChild5to6CheckBox";
            this.hasChild5to6CheckBox.Size = new System.Drawing.Size(47, 17);
            this.hasChild5to6CheckBox.TabIndex = 15;
            this.hasChild5to6CheckBox.Text = "5 - 6";
            this.hasChild5to6CheckBox.UseVisualStyleBackColor = true;
            // 
            // hasChild6to12CheckBox
            // 
            this.hasChild6to12CheckBox.AutoSize = true;
            this.hasChild6to12CheckBox.Location = new System.Drawing.Point(37, 320);
            this.hasChild6to12CheckBox.Name = "hasChild6to12CheckBox";
            this.hasChild6to12CheckBox.Size = new System.Drawing.Size(53, 17);
            this.hasChild6to12CheckBox.TabIndex = 16;
            this.hasChild6to12CheckBox.Text = "6 - 12";
            this.hasChild6to12CheckBox.UseVisualStyleBackColor = true;
            this.hasChild6to12CheckBox.CheckedChanged += new System.EventHandler(this.hasChild6to12CheckBox_CheckedChanged);
            // 
            // hasChild13to18CheckBox
            // 
            this.hasChild13to18CheckBox.AutoSize = true;
            this.hasChild13to18CheckBox.Location = new System.Drawing.Point(37, 343);
            this.hasChild13to18CheckBox.Name = "hasChild13to18CheckBox";
            this.hasChild13to18CheckBox.Size = new System.Drawing.Size(59, 17);
            this.hasChild13to18CheckBox.TabIndex = 17;
            this.hasChild13to18CheckBox.Text = "13 - 18";
            this.hasChild13to18CheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select all that apply, even if they overlap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Yearly Household Income";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // personalInfoTabControl
            // 
            this.personalInfoTabControl.Controls.Add(this.tabPage1);
            this.personalInfoTabControl.Controls.Add(this.eligibleProgramsTabPage);
            this.personalInfoTabControl.Location = new System.Drawing.Point(2, 2);
            this.personalInfoTabControl.Name = "personalInfoTabControl";
            this.personalInfoTabControl.SelectedIndex = 0;
            this.personalInfoTabControl.Size = new System.Drawing.Size(667, 474);
            this.personalInfoTabControl.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.undocumentedRadioButton);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ImmigrationStatusLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.usCitizenRadioButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lawFullyPresentRadioButton);
            this.tabPage1.Controls.Add(this.hasChild13to18CheckBox);
            this.tabPage1.Controls.Add(this.yearsPresentLabel);
            this.tabPage1.Controls.Add(this.hasChild6to12CheckBox);
            this.tabPage1.Controls.Add(this.yearsPresentTextBox);
            this.tabPage1.Controls.Add(this.hasChild5to6CheckBox);
            this.tabPage1.Controls.Add(this.fiveYearExemptCheckBox);
            this.tabPage1.Controls.Add(this.hasChild0to5CheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numberOfFamilyMemberstextBox1);
            this.tabPage1.Controls.Add(this.isPregnantCheckBox);
            this.tabPage1.Controls.Add(this.doesNotHaveChildrenCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(659, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoctorsCareEligibility.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(315, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 120);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // eligibleProgramsTabPage
            // 
            this.eligibleProgramsTabPage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.eligibleProgramsTabPage.Controls.Add(this.getMatchesButton);
            this.eligibleProgramsTabPage.Controls.Add(this.programDescriptionLabel);
            this.eligibleProgramsTabPage.Controls.Add(this.label5);
            this.eligibleProgramsTabPage.Controls.Add(this.eligibleProgramsListBox);
            this.eligibleProgramsTabPage.Location = new System.Drawing.Point(4, 22);
            this.eligibleProgramsTabPage.Name = "eligibleProgramsTabPage";
            this.eligibleProgramsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eligibleProgramsTabPage.Size = new System.Drawing.Size(659, 448);
            this.eligibleProgramsTabPage.TabIndex = 1;
            this.eligibleProgramsTabPage.Text = "Eligible Programs";
            // 
            // getMatchesButton
            // 
            this.getMatchesButton.Location = new System.Drawing.Point(35, 22);
            this.getMatchesButton.Name = "getMatchesButton";
            this.getMatchesButton.Size = new System.Drawing.Size(140, 23);
            this.getMatchesButton.TabIndex = 3;
            this.getMatchesButton.Text = "Get Matches!";
            this.getMatchesButton.UseVisualStyleBackColor = true;
            this.getMatchesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // programDescriptionLabel
            // 
            this.programDescriptionLabel.AutoSize = true;
            this.programDescriptionLabel.Location = new System.Drawing.Point(379, 75);
            this.programDescriptionLabel.Name = "programDescriptionLabel";
            this.programDescriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.programDescriptionLabel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Potential Program Matches";
            // 
            // eligibleProgramsListBox
            // 
            this.eligibleProgramsListBox.FormattingEnabled = true;
            this.eligibleProgramsListBox.Location = new System.Drawing.Point(35, 75);
            this.eligibleProgramsListBox.Name = "eligibleProgramsListBox";
            this.eligibleProgramsListBox.Size = new System.Drawing.Size(288, 342);
            this.eligibleProgramsListBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(672, 480);
            this.Controls.Add(this.personalInfoTabControl);
            this.Name = "Form1";
            this.Text = "Doctors Care Eligibility";
            this.personalInfoTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.eligibleProgramsTabPage.ResumeLayout(false);
            this.eligibleProgramsTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ImmigrationStatusLabel;
        private System.Windows.Forms.RadioButton usCitizenRadioButton;
        private System.Windows.Forms.RadioButton lawFullyPresentRadioButton;
        private System.Windows.Forms.RadioButton undocumentedRadioButton;
        private System.Windows.Forms.Label yearsPresentLabel;
        private System.Windows.Forms.TextBox yearsPresentTextBox;
        private System.Windows.Forms.CheckBox fiveYearExemptCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfFamilyMemberstextBox1;
        private System.Windows.Forms.CheckBox doesNotHaveChildrenCheckBox;
        private System.Windows.Forms.CheckBox isPregnantCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox hasChild0to5CheckBox;
        private System.Windows.Forms.CheckBox hasChild5to6CheckBox;
        private System.Windows.Forms.CheckBox hasChild6to12CheckBox;
        private System.Windows.Forms.CheckBox hasChild13to18CheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl personalInfoTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage eligibleProgramsTabPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox eligibleProgramsListBox;
        private System.Windows.Forms.Label programDescriptionLabel;
        private System.Windows.Forms.Button getMatchesButton;
    }
}

