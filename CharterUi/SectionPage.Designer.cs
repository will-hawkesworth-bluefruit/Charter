namespace CharterUi
{
    partial class SectionPage
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
            System.Windows.Forms.ListBox charterListBox;
            this.sprintSelectLabel = new System.Windows.Forms.Label();
            this.sprintSelectComboBox = new System.Windows.Forms.ComboBox();
            this.sectionSelectComboBox = new System.Windows.Forms.ComboBox();
            this.sectionSelectLabel = new System.Windows.Forms.Label();
            this.charterPurposeLabel = new System.Windows.Forms.Label();
            this.charterTestedByHeaderLabel = new System.Windows.Forms.Label();
            this.charterTestedByLabel = new System.Windows.Forms.Label();
            this.charterTestedOnHeaderLabel = new System.Windows.Forms.Label();
            this.charterTestedOnLabel = new System.Windows.Forms.Label();
            this.charterIssuesFoundLabelHeader = new System.Windows.Forms.Label();
            this.charterIssuesFoundLabel = new System.Windows.Forms.Label();
            this.sectionViewCharterButton = new System.Windows.Forms.Button();
            this.sectionEditCharterButton = new System.Windows.Forms.Button();
            this.sectionNewCharterButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            charterListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // charterListBox
            // 
            charterListBox.FormattingEnabled = true;
            charterListBox.ItemHeight = 25;
            charterListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            charterListBox.Location = new System.Drawing.Point(12, 66);
            charterListBox.Name = "charterListBox";
            charterListBox.Size = new System.Drawing.Size(231, 479);
            charterListBox.TabIndex = 12;
            // 
            // sprintSelectLabel
            // 
            this.sprintSelectLabel.AutoSize = true;
            this.sprintSelectLabel.Location = new System.Drawing.Point(410, 9);
            this.sprintSelectLabel.Name = "sprintSelectLabel";
            this.sprintSelectLabel.Size = new System.Drawing.Size(74, 25);
            this.sprintSelectLabel.TabIndex = 11;
            this.sprintSelectLabel.Text = "Sprint:";
            // 
            // sprintSelectComboBox
            // 
            this.sprintSelectComboBox.FormattingEnabled = true;
            this.sprintSelectComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "N/A"});
            this.sprintSelectComboBox.Location = new System.Drawing.Point(490, 6);
            this.sprintSelectComboBox.Name = "sprintSelectComboBox";
            this.sprintSelectComboBox.Size = new System.Drawing.Size(68, 33);
            this.sprintSelectComboBox.TabIndex = 10;
            this.sprintSelectComboBox.Text = "N/A";
            // 
            // sectionSelectComboBox
            // 
            this.sectionSelectComboBox.FormattingEnabled = true;
            this.sectionSelectComboBox.Items.AddRange(new object[] {
            "Home",
            "Roadmap",
            "Features",
            "Kanban",
            "Testing",
            "Reports",
            "Administration",
            "Diagnostics",
            "N/A"});
            this.sectionSelectComboBox.Location = new System.Drawing.Point(103, 6);
            this.sectionSelectComboBox.Name = "sectionSelectComboBox";
            this.sectionSelectComboBox.Size = new System.Drawing.Size(301, 33);
            this.sectionSelectComboBox.TabIndex = 9;
            this.sectionSelectComboBox.Text = "N/A";
            // 
            // sectionSelectLabel
            // 
            this.sectionSelectLabel.AutoSize = true;
            this.sectionSelectLabel.Location = new System.Drawing.Point(7, 9);
            this.sectionSelectLabel.Name = "sectionSelectLabel";
            this.sectionSelectLabel.Size = new System.Drawing.Size(90, 25);
            this.sectionSelectLabel.TabIndex = 8;
            this.sectionSelectLabel.Text = "Section:";
            // 
            // charterPurposeLabel
            // 
            this.charterPurposeLabel.AutoSize = true;
            this.charterPurposeLabel.Location = new System.Drawing.Point(442, 76);
            this.charterPurposeLabel.Name = "charterPurposeLabel";
            this.charterPurposeLabel.Size = new System.Drawing.Size(116, 25);
            this.charterPurposeLabel.TabIndex = 13;
            this.charterPurposeLabel.Text = "<Purpose>";
            // 
            // charterTestedByHeaderLabel
            // 
            this.charterTestedByHeaderLabel.AutoSize = true;
            this.charterTestedByHeaderLabel.Location = new System.Drawing.Point(390, 137);
            this.charterTestedByHeaderLabel.Name = "charterTestedByHeaderLabel";
            this.charterTestedByHeaderLabel.Size = new System.Drawing.Size(115, 25);
            this.charterTestedByHeaderLabel.TabIndex = 14;
            this.charterTestedByHeaderLabel.Text = "Tested By:";
            // 
            // charterTestedByLabel
            // 
            this.charterTestedByLabel.AutoSize = true;
            this.charterTestedByLabel.Location = new System.Drawing.Point(530, 137);
            this.charterTestedByLabel.Name = "charterTestedByLabel";
            this.charterTestedByLabel.Size = new System.Drawing.Size(92, 25);
            this.charterTestedByLabel.TabIndex = 15;
            this.charterTestedByLabel.Text = "<Name>";
            // 
            // charterTestedOnHeaderLabel
            // 
            this.charterTestedOnHeaderLabel.AutoSize = true;
            this.charterTestedOnHeaderLabel.Location = new System.Drawing.Point(390, 201);
            this.charterTestedOnHeaderLabel.Name = "charterTestedOnHeaderLabel";
            this.charterTestedOnHeaderLabel.Size = new System.Drawing.Size(118, 25);
            this.charterTestedOnHeaderLabel.TabIndex = 16;
            this.charterTestedOnHeaderLabel.Text = "Tested On:";
            // 
            // charterTestedOnLabel
            // 
            this.charterTestedOnLabel.AutoSize = true;
            this.charterTestedOnLabel.Location = new System.Drawing.Point(530, 201);
            this.charterTestedOnLabel.Name = "charterTestedOnLabel";
            this.charterTestedOnLabel.Size = new System.Drawing.Size(81, 25);
            this.charterTestedOnLabel.TabIndex = 17;
            this.charterTestedOnLabel.Text = "<Date>";
            // 
            // charterIssuesFoundLabelHeader
            // 
            this.charterIssuesFoundLabelHeader.AutoSize = true;
            this.charterIssuesFoundLabelHeader.Location = new System.Drawing.Point(361, 265);
            this.charterIssuesFoundLabelHeader.Name = "charterIssuesFoundLabelHeader";
            this.charterIssuesFoundLabelHeader.Size = new System.Drawing.Size(147, 25);
            this.charterIssuesFoundLabelHeader.TabIndex = 18;
            this.charterIssuesFoundLabelHeader.Text = "Issues Found:";
            // 
            // charterIssuesFoundLabel
            // 
            this.charterIssuesFoundLabel.AutoSize = true;
            this.charterIssuesFoundLabel.Location = new System.Drawing.Point(524, 265);
            this.charterIssuesFoundLabel.Name = "charterIssuesFoundLabel";
            this.charterIssuesFoundLabel.Size = new System.Drawing.Size(98, 25);
            this.charterIssuesFoundLabel.TabIndex = 19;
            this.charterIssuesFoundLabel.Text = "<Issues>";
            // 
            // sectionViewCharterButton
            // 
            this.sectionViewCharterButton.Location = new System.Drawing.Point(401, 338);
            this.sectionViewCharterButton.Name = "sectionViewCharterButton";
            this.sectionViewCharterButton.Size = new System.Drawing.Size(220, 37);
            this.sectionViewCharterButton.TabIndex = 20;
            this.sectionViewCharterButton.Text = "View Charter";
            this.sectionViewCharterButton.UseVisualStyleBackColor = true;
            this.sectionViewCharterButton.Click += new System.EventHandler(this.sectionViewCharterButton_Click);
            // 
            // sectionEditCharterButton
            // 
            this.sectionEditCharterButton.Location = new System.Drawing.Point(402, 393);
            this.sectionEditCharterButton.Name = "sectionEditCharterButton";
            this.sectionEditCharterButton.Size = new System.Drawing.Size(220, 37);
            this.sectionEditCharterButton.TabIndex = 21;
            this.sectionEditCharterButton.Text = "Edit Charter";
            this.sectionEditCharterButton.UseVisualStyleBackColor = true;
            this.sectionEditCharterButton.Click += new System.EventHandler(this.sectionEditCharterButton_Click);
            // 
            // sectionNewCharterButton
            // 
            this.sectionNewCharterButton.Location = new System.Drawing.Point(402, 449);
            this.sectionNewCharterButton.Name = "sectionNewCharterButton";
            this.sectionNewCharterButton.Size = new System.Drawing.Size(220, 37);
            this.sectionNewCharterButton.TabIndex = 22;
            this.sectionNewCharterButton.Text = "New Charter";
            this.sectionNewCharterButton.UseVisualStyleBackColor = true;
            this.sectionNewCharterButton.Click += new System.EventHandler(this.sectionNewCharterButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(734, 6);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(34, 37);
            this.helpButton.TabIndex = 23;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // SectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.sectionNewCharterButton);
            this.Controls.Add(this.sectionEditCharterButton);
            this.Controls.Add(this.sectionViewCharterButton);
            this.Controls.Add(this.charterIssuesFoundLabel);
            this.Controls.Add(this.charterIssuesFoundLabelHeader);
            this.Controls.Add(this.charterTestedOnLabel);
            this.Controls.Add(this.charterTestedOnHeaderLabel);
            this.Controls.Add(this.charterTestedByLabel);
            this.Controls.Add(this.charterTestedByHeaderLabel);
            this.Controls.Add(this.charterPurposeLabel);
            this.Controls.Add(charterListBox);
            this.Controls.Add(this.sprintSelectLabel);
            this.Controls.Add(this.sprintSelectComboBox);
            this.Controls.Add(this.sectionSelectComboBox);
            this.Controls.Add(this.sectionSelectLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "SectionPage";
            this.ShowIcon = false;
            this.Text = "Charter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sprintSelectLabel;
        private System.Windows.Forms.ComboBox sprintSelectComboBox;
        private System.Windows.Forms.ComboBox sectionSelectComboBox;
        private System.Windows.Forms.Label sectionSelectLabel;
        private System.Windows.Forms.Label charterPurposeLabel;
        private System.Windows.Forms.Label charterTestedByHeaderLabel;
        private System.Windows.Forms.Label charterTestedByLabel;
        private System.Windows.Forms.Label charterTestedOnHeaderLabel;
        private System.Windows.Forms.Label charterTestedOnLabel;
        private System.Windows.Forms.Label charterIssuesFoundLabelHeader;
        private System.Windows.Forms.Label charterIssuesFoundLabel;
        private System.Windows.Forms.Button sectionViewCharterButton;
        private System.Windows.Forms.Button sectionEditCharterButton;
        private System.Windows.Forms.Button sectionNewCharterButton;
        private System.Windows.Forms.Button helpButton;
    }
}