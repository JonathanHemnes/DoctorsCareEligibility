﻿namespace DoctorsCareEligibility
{
    partial class MainWindow
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
            this.numberOfFamilyMembersTextBox = new System.Windows.Forms.TextBox();
            this.isPregnantCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yearlyIncomeTextBox = new System.Windows.Forms.TextBox();
            this.personalInfoTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ageNineteenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageEighteenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageSeventeenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageSixteenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageFifteenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageFourteenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageThirteenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageTwelveCheckBox = new System.Windows.Forms.CheckBox();
            this.ageElevenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageTenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageNineCheckBox = new System.Windows.Forms.CheckBox();
            this.ageEightCheckBox = new System.Windows.Forms.CheckBox();
            this.ageSevenCheckBox = new System.Windows.Forms.CheckBox();
            this.ageSixcheckBox = new System.Windows.Forms.CheckBox();
            this.ageFiveCheckBox = new System.Windows.Forms.CheckBox();
            this.ageFourCheckBox = new System.Windows.Forms.CheckBox();
            this.ageThreeCheckBox = new System.Windows.Forms.CheckBox();
            this.ageTwoCheckBox = new System.Windows.Forms.CheckBox();
            this.ageOneCheckbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eligibleProgramsTabPage = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.elibleListMatchingNoteLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.showAllProgramsButton = new System.Windows.Forms.Button();
            this.getMatchesButton = new System.Windows.Forms.Button();
            this.programDescriptionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eligibleProgramsListBox = new System.Windows.Forms.ListBox();
            this.ProgramFormLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkToFormButton = new System.Windows.Forms.Button();
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
            // numberOfFamilyMembersTextBox
            // 
            this.numberOfFamilyMembersTextBox.Location = new System.Drawing.Point(37, 139);
            this.numberOfFamilyMembersTextBox.Name = "numberOfFamilyMembersTextBox";
            this.numberOfFamilyMembersTextBox.Size = new System.Drawing.Size(97, 20);
            this.numberOfFamilyMembersTextBox.TabIndex = 8;
            // 
            // isPregnantCheckBox
            // 
            this.isPregnantCheckBox.AutoSize = true;
            this.isPregnantCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPregnantCheckBox.Location = new System.Drawing.Point(37, 223);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Select all that apply";
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
            // yearlyIncomeTextBox
            // 
            this.yearlyIncomeTextBox.Location = new System.Drawing.Point(315, 139);
            this.yearlyIncomeTextBox.Name = "yearlyIncomeTextBox";
            this.yearlyIncomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearlyIncomeTextBox.TabIndex = 20;
            // 
            // personalInfoTabControl
            // 
            this.personalInfoTabControl.Controls.Add(this.tabPage1);
            this.personalInfoTabControl.Controls.Add(this.eligibleProgramsTabPage);
            this.personalInfoTabControl.Location = new System.Drawing.Point(2, 2);
            this.personalInfoTabControl.Name = "personalInfoTabControl";
            this.personalInfoTabControl.SelectedIndex = 0;
            this.personalInfoTabControl.Size = new System.Drawing.Size(602, 434);
            this.personalInfoTabControl.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.tabPage1.Controls.Add(this.ageNineteenCheckBox);
            this.tabPage1.Controls.Add(this.ageEighteenCheckBox);
            this.tabPage1.Controls.Add(this.ageSeventeenCheckBox);
            this.tabPage1.Controls.Add(this.ageSixteenCheckBox);
            this.tabPage1.Controls.Add(this.ageFifteenCheckBox);
            this.tabPage1.Controls.Add(this.ageFourteenCheckBox);
            this.tabPage1.Controls.Add(this.ageThirteenCheckBox);
            this.tabPage1.Controls.Add(this.ageTwelveCheckBox);
            this.tabPage1.Controls.Add(this.ageElevenCheckBox);
            this.tabPage1.Controls.Add(this.ageTenCheckBox);
            this.tabPage1.Controls.Add(this.ageNineCheckBox);
            this.tabPage1.Controls.Add(this.ageEightCheckBox);
            this.tabPage1.Controls.Add(this.ageSevenCheckBox);
            this.tabPage1.Controls.Add(this.ageSixcheckBox);
            this.tabPage1.Controls.Add(this.ageFiveCheckBox);
            this.tabPage1.Controls.Add(this.ageFourCheckBox);
            this.tabPage1.Controls.Add(this.ageThreeCheckBox);
            this.tabPage1.Controls.Add(this.ageTwoCheckBox);
            this.tabPage1.Controls.Add(this.ageOneCheckbox);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.undocumentedRadioButton);
            this.tabPage1.Controls.Add(this.yearlyIncomeTextBox);
            this.tabPage1.Controls.Add(this.ImmigrationStatusLabel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.usCitizenRadioButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lawFullyPresentRadioButton);
            this.tabPage1.Controls.Add(this.yearsPresentLabel);
            this.tabPage1.Controls.Add(this.yearsPresentTextBox);
            this.tabPage1.Controls.Add(this.fiveYearExemptCheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.numberOfFamilyMembersTextBox);
            this.tabPage1.Controls.Add(this.isPregnantCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 408);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal Information";
            // 
            // ageNineteenCheckBox
            // 
            this.ageNineteenCheckBox.AutoSize = true;
            this.ageNineteenCheckBox.Location = new System.Drawing.Point(232, 292);
            this.ageNineteenCheckBox.Name = "ageNineteenCheckBox";
            this.ageNineteenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageNineteenCheckBox.TabIndex = 40;
            this.ageNineteenCheckBox.Text = "19";
            this.ageNineteenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageEighteenCheckBox
            // 
            this.ageEighteenCheckBox.AutoSize = true;
            this.ageEighteenCheckBox.Location = new System.Drawing.Point(232, 269);
            this.ageEighteenCheckBox.Name = "ageEighteenCheckBox";
            this.ageEighteenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageEighteenCheckBox.TabIndex = 39;
            this.ageEighteenCheckBox.Text = "18";
            this.ageEighteenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageSeventeenCheckBox
            // 
            this.ageSeventeenCheckBox.AutoSize = true;
            this.ageSeventeenCheckBox.Location = new System.Drawing.Point(232, 246);
            this.ageSeventeenCheckBox.Name = "ageSeventeenCheckBox";
            this.ageSeventeenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageSeventeenCheckBox.TabIndex = 38;
            this.ageSeventeenCheckBox.Text = "17";
            this.ageSeventeenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageSixteenCheckBox
            // 
            this.ageSixteenCheckBox.AutoSize = true;
            this.ageSixteenCheckBox.Location = new System.Drawing.Point(232, 223);
            this.ageSixteenCheckBox.Name = "ageSixteenCheckBox";
            this.ageSixteenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageSixteenCheckBox.TabIndex = 37;
            this.ageSixteenCheckBox.Text = "16";
            this.ageSixteenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageFifteenCheckBox
            // 
            this.ageFifteenCheckBox.AutoSize = true;
            this.ageFifteenCheckBox.Location = new System.Drawing.Point(130, 384);
            this.ageFifteenCheckBox.Name = "ageFifteenCheckBox";
            this.ageFifteenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageFifteenCheckBox.TabIndex = 36;
            this.ageFifteenCheckBox.Text = "15";
            this.ageFifteenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageFourteenCheckBox
            // 
            this.ageFourteenCheckBox.AutoSize = true;
            this.ageFourteenCheckBox.Location = new System.Drawing.Point(130, 361);
            this.ageFourteenCheckBox.Name = "ageFourteenCheckBox";
            this.ageFourteenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageFourteenCheckBox.TabIndex = 35;
            this.ageFourteenCheckBox.Text = "14";
            this.ageFourteenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageThirteenCheckBox
            // 
            this.ageThirteenCheckBox.AutoSize = true;
            this.ageThirteenCheckBox.Location = new System.Drawing.Point(130, 338);
            this.ageThirteenCheckBox.Name = "ageThirteenCheckBox";
            this.ageThirteenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageThirteenCheckBox.TabIndex = 34;
            this.ageThirteenCheckBox.Text = "13";
            this.ageThirteenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageTwelveCheckBox
            // 
            this.ageTwelveCheckBox.AutoSize = true;
            this.ageTwelveCheckBox.Location = new System.Drawing.Point(130, 315);
            this.ageTwelveCheckBox.Name = "ageTwelveCheckBox";
            this.ageTwelveCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageTwelveCheckBox.TabIndex = 33;
            this.ageTwelveCheckBox.Text = "12";
            this.ageTwelveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageElevenCheckBox
            // 
            this.ageElevenCheckBox.AutoSize = true;
            this.ageElevenCheckBox.Location = new System.Drawing.Point(130, 292);
            this.ageElevenCheckBox.Name = "ageElevenCheckBox";
            this.ageElevenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageElevenCheckBox.TabIndex = 32;
            this.ageElevenCheckBox.Text = "11";
            this.ageElevenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageTenCheckBox
            // 
            this.ageTenCheckBox.AutoSize = true;
            this.ageTenCheckBox.Location = new System.Drawing.Point(130, 269);
            this.ageTenCheckBox.Name = "ageTenCheckBox";
            this.ageTenCheckBox.Size = new System.Drawing.Size(38, 17);
            this.ageTenCheckBox.TabIndex = 31;
            this.ageTenCheckBox.Text = "10";
            this.ageTenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageNineCheckBox
            // 
            this.ageNineCheckBox.AutoSize = true;
            this.ageNineCheckBox.Location = new System.Drawing.Point(130, 246);
            this.ageNineCheckBox.Name = "ageNineCheckBox";
            this.ageNineCheckBox.Size = new System.Drawing.Size(32, 17);
            this.ageNineCheckBox.TabIndex = 30;
            this.ageNineCheckBox.Text = "9";
            this.ageNineCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageEightCheckBox
            // 
            this.ageEightCheckBox.AutoSize = true;
            this.ageEightCheckBox.Location = new System.Drawing.Point(130, 223);
            this.ageEightCheckBox.Name = "ageEightCheckBox";
            this.ageEightCheckBox.Size = new System.Drawing.Size(32, 17);
            this.ageEightCheckBox.TabIndex = 29;
            this.ageEightCheckBox.Text = "8";
            this.ageEightCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageSevenCheckBox
            // 
            this.ageSevenCheckBox.AutoSize = true;
            this.ageSevenCheckBox.Location = new System.Drawing.Point(37, 384);
            this.ageSevenCheckBox.Name = "ageSevenCheckBox";
            this.ageSevenCheckBox.Size = new System.Drawing.Size(32, 17);
            this.ageSevenCheckBox.TabIndex = 28;
            this.ageSevenCheckBox.Text = "7";
            this.ageSevenCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageSixcheckBox
            // 
            this.ageSixcheckBox.AutoSize = true;
            this.ageSixcheckBox.Location = new System.Drawing.Point(37, 361);
            this.ageSixcheckBox.Name = "ageSixcheckBox";
            this.ageSixcheckBox.Size = new System.Drawing.Size(32, 17);
            this.ageSixcheckBox.TabIndex = 27;
            this.ageSixcheckBox.Text = "6";
            this.ageSixcheckBox.UseVisualStyleBackColor = true;
            // 
            // ageFiveCheckBox
            // 
            this.ageFiveCheckBox.AutoSize = true;
            this.ageFiveCheckBox.Location = new System.Drawing.Point(37, 338);
            this.ageFiveCheckBox.Name = "ageFiveCheckBox";
            this.ageFiveCheckBox.Size = new System.Drawing.Size(32, 17);
            this.ageFiveCheckBox.TabIndex = 26;
            this.ageFiveCheckBox.Text = "5";
            this.ageFiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageFourCheckBox
            // 
            this.ageFourCheckBox.AutoSize = true;
            this.ageFourCheckBox.Location = new System.Drawing.Point(37, 315);
            this.ageFourCheckBox.Name = "ageFourCheckBox";
            this.ageFourCheckBox.Size = new System.Drawing.Size(32, 17);
            this.ageFourCheckBox.TabIndex = 25;
            this.ageFourCheckBox.Text = "4";
            this.ageFourCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageThreeCheckBox
            // 
            this.ageThreeCheckBox.AutoSize = true;
            this.ageThreeCheckBox.Location = new System.Drawing.Point(37, 292);
            this.ageThreeCheckBox.Name = "ageThreeCheckBox";
            this.ageThreeCheckBox.Size = new System.Drawing.Size(32, 17);
            this.ageThreeCheckBox.TabIndex = 24;
            this.ageThreeCheckBox.Text = "3";
            this.ageThreeCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageTwoCheckBox
            // 
            this.ageTwoCheckBox.AutoSize = true;
            this.ageTwoCheckBox.Location = new System.Drawing.Point(37, 269);
            this.ageTwoCheckBox.Name = "ageTwoCheckBox";
            this.ageTwoCheckBox.Size = new System.Drawing.Size(32, 17);
            this.ageTwoCheckBox.TabIndex = 23;
            this.ageTwoCheckBox.Text = "2";
            this.ageTwoCheckBox.UseVisualStyleBackColor = true;
            // 
            // ageOneCheckbox
            // 
            this.ageOneCheckbox.AutoSize = true;
            this.ageOneCheckbox.Location = new System.Drawing.Point(37, 246);
            this.ageOneCheckbox.Name = "ageOneCheckbox";
            this.ageOneCheckbox.Size = new System.Drawing.Size(32, 17);
            this.ageOneCheckbox.TabIndex = 22;
            this.ageOneCheckbox.Text = "1";
            this.ageOneCheckbox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoctorsCareEligibility.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(306, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 120);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // eligibleProgramsTabPage
            // 
            this.eligibleProgramsTabPage.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.eligibleProgramsTabPage.Controls.Add(this.linkToFormButton);
            this.eligibleProgramsTabPage.Controls.Add(this.ProgramFormLinkLabel);
            this.eligibleProgramsTabPage.Controls.Add(this.label6);
            this.eligibleProgramsTabPage.Controls.Add(this.elibleListMatchingNoteLabel);
            this.eligibleProgramsTabPage.Controls.Add(this.noteLabel);
            this.eligibleProgramsTabPage.Controls.Add(this.showAllProgramsButton);
            this.eligibleProgramsTabPage.Controls.Add(this.getMatchesButton);
            this.eligibleProgramsTabPage.Controls.Add(this.programDescriptionLabel);
            this.eligibleProgramsTabPage.Controls.Add(this.label5);
            this.eligibleProgramsTabPage.Controls.Add(this.eligibleProgramsListBox);
            this.eligibleProgramsTabPage.Location = new System.Drawing.Point(4, 22);
            this.eligibleProgramsTabPage.Name = "eligibleProgramsTabPage";
            this.eligibleProgramsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.eligibleProgramsTabPage.Size = new System.Drawing.Size(594, 408);
            this.eligibleProgramsTabPage.TabIndex = 1;
            this.eligibleProgramsTabPage.Text = "Eligible Programs";
            this.eligibleProgramsTabPage.Click += new System.EventHandler(this.eligibleProgramsTabPage_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Notes";
            // 
            // elibleListMatchingNoteLabel
            // 
            this.elibleListMatchingNoteLabel.AutoSize = true;
            this.elibleListMatchingNoteLabel.Location = new System.Drawing.Point(345, 76);
            this.elibleListMatchingNoteLabel.MaximumSize = new System.Drawing.Size(175, 200);
            this.elibleListMatchingNoteLabel.Name = "elibleListMatchingNoteLabel";
            this.elibleListMatchingNoteLabel.Size = new System.Drawing.Size(0, 13);
            this.elibleListMatchingNoteLabel.TabIndex = 6;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(348, 79);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(0, 13);
            this.noteLabel.TabIndex = 5;
            // 
            // showAllProgramsButton
            // 
            this.showAllProgramsButton.Location = new System.Drawing.Point(336, 22);
            this.showAllProgramsButton.Name = "showAllProgramsButton";
            this.showAllProgramsButton.Size = new System.Drawing.Size(230, 23);
            this.showAllProgramsButton.TabIndex = 4;
            this.showAllProgramsButton.Text = "Show All Programs";
            this.showAllProgramsButton.UseVisualStyleBackColor = true;
            this.showAllProgramsButton.Click += new System.EventHandler(this.showAllProgramsButton_Click);
            // 
            // getMatchesButton
            // 
            this.getMatchesButton.Location = new System.Drawing.Point(35, 22);
            this.getMatchesButton.Name = "getMatchesButton";
            this.getMatchesButton.Size = new System.Drawing.Size(273, 23);
            this.getMatchesButton.TabIndex = 3;
            this.getMatchesButton.Text = "Get Matches";
            this.getMatchesButton.UseVisualStyleBackColor = true;
            this.getMatchesButton.Click += new System.EventHandler(this.getMatchesButton_Click);
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
            this.eligibleProgramsListBox.Size = new System.Drawing.Size(273, 303);
            this.eligibleProgramsListBox.TabIndex = 0;
            // 
            // ProgramFormLinkLabel
            // 
            this.ProgramFormLinkLabel.AutoSize = true;
            this.ProgramFormLinkLabel.Location = new System.Drawing.Point(348, 246);
            this.ProgramFormLinkLabel.Name = "ProgramFormLinkLabel";
            this.ProgramFormLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.ProgramFormLinkLabel.TabIndex = 8;
            // 
            // linkToFormButton
            // 
            this.linkToFormButton.Location = new System.Drawing.Point(336, 260);
            this.linkToFormButton.Name = "linkToFormButton";
            this.linkToFormButton.Size = new System.Drawing.Size(230, 24);
            this.linkToFormButton.TabIndex = 9;
            this.linkToFormButton.Text = "Bring Me To The Website";
            this.linkToFormButton.UseVisualStyleBackColor = true;
            this.linkToFormButton.Click += new System.EventHandler(this.linkToFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 433);
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
        private System.Windows.Forms.TextBox numberOfFamilyMembersTextBox;
        private System.Windows.Forms.CheckBox isPregnantCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yearlyIncomeTextBox;
        private System.Windows.Forms.TabControl personalInfoTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage eligibleProgramsTabPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox eligibleProgramsListBox;
        private System.Windows.Forms.CheckBox ageNineteenCheckBox;
        private System.Windows.Forms.CheckBox ageEighteenCheckBox;
        private System.Windows.Forms.CheckBox ageSeventeenCheckBox;
        private System.Windows.Forms.CheckBox ageSixteenCheckBox;
        private System.Windows.Forms.CheckBox ageFifteenCheckBox;
        private System.Windows.Forms.CheckBox ageFourteenCheckBox;
        private System.Windows.Forms.CheckBox ageThirteenCheckBox;
        private System.Windows.Forms.CheckBox ageTwelveCheckBox;
        private System.Windows.Forms.CheckBox ageElevenCheckBox;
        private System.Windows.Forms.CheckBox ageTenCheckBox;
        private System.Windows.Forms.CheckBox ageNineCheckBox;
        private System.Windows.Forms.CheckBox ageEightCheckBox;
        private System.Windows.Forms.CheckBox ageSevenCheckBox;
        private System.Windows.Forms.CheckBox ageSixcheckBox;
        private System.Windows.Forms.CheckBox ageFiveCheckBox;
        private System.Windows.Forms.CheckBox ageFourCheckBox;
        private System.Windows.Forms.CheckBox ageThreeCheckBox;
        private System.Windows.Forms.CheckBox ageTwoCheckBox;
        private System.Windows.Forms.CheckBox ageOneCheckbox;
        private System.Windows.Forms.Button getMatchesButton;
        private System.Windows.Forms.Button showAllProgramsButton;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label programDescriptionLabel;
        private System.Windows.Forms.Label elibleListMatchingNoteLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel ProgramFormLinkLabel;
        private System.Windows.Forms.Button linkToFormButton;
    }
}

