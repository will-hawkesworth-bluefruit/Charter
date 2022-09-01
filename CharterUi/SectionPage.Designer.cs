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
            this.navSectionPageSprintLabel = new System.Windows.Forms.Label();
            this.navSectionPageSprintComboBox = new System.Windows.Forms.ComboBox();
            this.navSectionPageSectionComboBox = new System.Windows.Forms.ComboBox();
            this.navSectionPageSectionLabel = new System.Windows.Forms.Label();
            this.navSectionPageProjectLabel = new System.Windows.Forms.Label();
            this.navSectionPageProjectComboBox = new System.Windows.Forms.ComboBox();
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
            // navSectionPageSprintLabel
            // 
            this.navSectionPageSprintLabel.AutoSize = true;
            this.navSectionPageSprintLabel.Location = new System.Drawing.Point(612, 15);
            this.navSectionPageSprintLabel.Name = "navSectionPageSprintLabel";
            this.navSectionPageSprintLabel.Size = new System.Drawing.Size(74, 25);
            this.navSectionPageSprintLabel.TabIndex = 11;
            this.navSectionPageSprintLabel.Text = "Sprint:";
            // 
            // navSectionPageSprintComboBox
            // 
            this.navSectionPageSprintComboBox.FormattingEnabled = true;
            this.navSectionPageSprintComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "N/A"});
            this.navSectionPageSprintComboBox.Location = new System.Drawing.Point(692, 12);
            this.navSectionPageSprintComboBox.Name = "navSectionPageSprintComboBox";
            this.navSectionPageSprintComboBox.Size = new System.Drawing.Size(54, 33);
            this.navSectionPageSprintComboBox.TabIndex = 10;
            this.navSectionPageSprintComboBox.Text = "N/A";
            // 
            // navSectionPageSectionComboBox
            // 
            this.navSectionPageSectionComboBox.FormattingEnabled = true;
            this.navSectionPageSectionComboBox.Items.AddRange(new object[] {
            "Home",
            "Roadmap",
            "Features",
            "Kanban",
            "Testing",
            "Reports",
            "Administration",
            "Diagnostics",
            "N/A"});
            this.navSectionPageSectionComboBox.Location = new System.Drawing.Point(401, 12);
            this.navSectionPageSectionComboBox.Name = "navSectionPageSectionComboBox";
            this.navSectionPageSectionComboBox.Size = new System.Drawing.Size(205, 33);
            this.navSectionPageSectionComboBox.TabIndex = 9;
            this.navSectionPageSectionComboBox.Text = "N/A";
            // 
            // navSectionPageSectionLabel
            // 
            this.navSectionPageSectionLabel.AutoSize = true;
            this.navSectionPageSectionLabel.Location = new System.Drawing.Point(305, 15);
            this.navSectionPageSectionLabel.Name = "navSectionPageSectionLabel";
            this.navSectionPageSectionLabel.Size = new System.Drawing.Size(90, 25);
            this.navSectionPageSectionLabel.TabIndex = 8;
            this.navSectionPageSectionLabel.Text = "Section:";
            // 
            // navSectionPageProjectLabel
            // 
            this.navSectionPageProjectLabel.AutoSize = true;
            this.navSectionPageProjectLabel.Location = new System.Drawing.Point(3, 15);
            this.navSectionPageProjectLabel.Name = "navSectionPageProjectLabel";
            this.navSectionPageProjectLabel.Size = new System.Drawing.Size(85, 25);
            this.navSectionPageProjectLabel.TabIndex = 7;
            this.navSectionPageProjectLabel.Text = "Project:";
            // 
            // navSectionPageProjectComboBox
            // 
            this.navSectionPageProjectComboBox.FormattingEnabled = true;
            this.navSectionPageProjectComboBox.Items.AddRange(new object[] {
            "Mission Control",
            "N/A"});
            this.navSectionPageProjectComboBox.Location = new System.Drawing.Point(94, 12);
            this.navSectionPageProjectComboBox.Name = "navSectionPageProjectComboBox";
            this.navSectionPageProjectComboBox.Size = new System.Drawing.Size(205, 33);
            this.navSectionPageProjectComboBox.TabIndex = 6;
            this.navSectionPageProjectComboBox.Text = "N/A";
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
            // SectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 557);
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
            this.Controls.Add(this.navSectionPageSprintLabel);
            this.Controls.Add(this.navSectionPageSprintComboBox);
            this.Controls.Add(this.navSectionPageSectionComboBox);
            this.Controls.Add(this.navSectionPageSectionLabel);
            this.Controls.Add(this.navSectionPageProjectLabel);
            this.Controls.Add(this.navSectionPageProjectComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "SectionPage";
            this.ShowIcon = false;
            this.Text = "Charter";
            this.Load += new System.EventHandler(this.SectionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label navSectionPageSprintLabel;
        private System.Windows.Forms.ComboBox navSectionPageSprintComboBox;
        private System.Windows.Forms.ComboBox navSectionPageSectionComboBox;
        private System.Windows.Forms.Label navSectionPageSectionLabel;
        private System.Windows.Forms.Label navSectionPageProjectLabel;
        private System.Windows.Forms.ComboBox navSectionPageProjectComboBox;
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
    }
}