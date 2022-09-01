namespace CharterUi
{
    partial class ProjectPage
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
            System.Windows.Forms.ListBox sectionListBox;
            this.navProjectPageProjectComboBox = new System.Windows.Forms.ComboBox();
            this.navProjectPageProjectLabel = new System.Windows.Forms.Label();
            this.navSectionPageSectionLabel = new System.Windows.Forms.Label();
            this.navProjectPageSectionComboBox = new System.Windows.Forms.ComboBox();
            this.navProjectPageSprintComboBox = new System.Windows.Forms.ComboBox();
            this.navProjectPageSprintLabel = new System.Windows.Forms.Label();
            this.sectionDescriptionLabel = new System.Windows.Forms.Label();
            this.sectionRatingHeaderLabel = new System.Windows.Forms.Label();
            this.sectionRatingLabel = new System.Windows.Forms.Label();
            this.sectionScoreHeaderLabel = new System.Windows.Forms.Label();
            this.sectionScoreLabel = new System.Windows.Forms.Label();
            this.sectionTestedByHeaderLabel = new System.Windows.Forms.Label();
            this.sectionLastTestedByLabel = new System.Windows.Forms.Label();
            this.sectionLastedTestedOnHeaderLabel = new System.Windows.Forms.Label();
            this.sectionLastedTestedOnLabel = new System.Windows.Forms.Label();
            this.projectViewCharterButton = new System.Windows.Forms.Button();
            sectionListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sectionListBox
            // 
            sectionListBox.FormattingEnabled = true;
            sectionListBox.ItemHeight = 25;
            sectionListBox.Items.AddRange(new object[] {
            "Home",
            "Roadmap",
            "Features",
            "Kanban",
            "Testing",
            "Reports",
            "Administration",
            "Diagnostics"});
            sectionListBox.Location = new System.Drawing.Point(12, 66);
            sectionListBox.Name = "sectionListBox";
            sectionListBox.Size = new System.Drawing.Size(231, 479);
            sectionListBox.TabIndex = 6;
            // 
            // navProjectPageProjectComboBox
            // 
            this.navProjectPageProjectComboBox.FormattingEnabled = true;
            this.navProjectPageProjectComboBox.Items.AddRange(new object[] {
            "Mission Control",
            "N/A"});
            this.navProjectPageProjectComboBox.Location = new System.Drawing.Point(94, 12);
            this.navProjectPageProjectComboBox.Name = "navProjectPageProjectComboBox";
            this.navProjectPageProjectComboBox.Size = new System.Drawing.Size(205, 33);
            this.navProjectPageProjectComboBox.TabIndex = 0;
            this.navProjectPageProjectComboBox.Text = "N/A";
            // 
            // navProjectPageProjectLabel
            // 
            this.navProjectPageProjectLabel.AutoSize = true;
            this.navProjectPageProjectLabel.Location = new System.Drawing.Point(3, 15);
            this.navProjectPageProjectLabel.Name = "navProjectPageProjectLabel";
            this.navProjectPageProjectLabel.Size = new System.Drawing.Size(85, 25);
            this.navProjectPageProjectLabel.TabIndex = 1;
            this.navProjectPageProjectLabel.Text = "Project:";
            // 
            // navSectionPageSectionLabel
            // 
            this.navSectionPageSectionLabel.AutoSize = true;
            this.navSectionPageSectionLabel.Location = new System.Drawing.Point(305, 15);
            this.navSectionPageSectionLabel.Name = "navSectionPageSectionLabel";
            this.navSectionPageSectionLabel.Size = new System.Drawing.Size(90, 25);
            this.navSectionPageSectionLabel.TabIndex = 2;
            this.navSectionPageSectionLabel.Text = "Section:";
            // 
            // navProjectPageSectionComboBox
            // 
            this.navProjectPageSectionComboBox.FormattingEnabled = true;
            this.navProjectPageSectionComboBox.Items.AddRange(new object[] {
            "Home",
            "Roadmap",
            "Features",
            "Kanban",
            "Testing",
            "Reports",
            "Administration",
            "Diagnostics",
            "N/A"});
            this.navProjectPageSectionComboBox.Location = new System.Drawing.Point(401, 12);
            this.navProjectPageSectionComboBox.Name = "navProjectPageSectionComboBox";
            this.navProjectPageSectionComboBox.Size = new System.Drawing.Size(205, 33);
            this.navProjectPageSectionComboBox.TabIndex = 3;
            this.navProjectPageSectionComboBox.Text = "N/A";
            this.navProjectPageSectionComboBox.SelectedIndexChanged += new System.EventHandler(this.navProjectPageSectionComboBox_SelectedIndexChanged);
            // 
            // navProjectPageSprintComboBox
            // 
            this.navProjectPageSprintComboBox.Enabled = false;
            this.navProjectPageSprintComboBox.FormattingEnabled = true;
            this.navProjectPageSprintComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "N/A"});
            this.navProjectPageSprintComboBox.Location = new System.Drawing.Point(692, 12);
            this.navProjectPageSprintComboBox.Name = "navProjectPageSprintComboBox";
            this.navProjectPageSprintComboBox.Size = new System.Drawing.Size(54, 33);
            this.navProjectPageSprintComboBox.TabIndex = 4;
            this.navProjectPageSprintComboBox.Text = "N/A";
            // 
            // navProjectPageSprintLabel
            // 
            this.navProjectPageSprintLabel.AutoSize = true;
            this.navProjectPageSprintLabel.Location = new System.Drawing.Point(612, 15);
            this.navProjectPageSprintLabel.Name = "navProjectPageSprintLabel";
            this.navProjectPageSprintLabel.Size = new System.Drawing.Size(74, 25);
            this.navProjectPageSprintLabel.TabIndex = 5;
            this.navProjectPageSprintLabel.Text = "Sprint:";
            // 
            // sectionDescriptionLabel
            // 
            this.sectionDescriptionLabel.AutoSize = true;
            this.sectionDescriptionLabel.Location = new System.Drawing.Point(405, 76);
            this.sectionDescriptionLabel.Name = "sectionDescriptionLabel";
            this.sectionDescriptionLabel.Size = new System.Drawing.Size(222, 25);
            this.sectionDescriptionLabel.TabIndex = 7;
            this.sectionDescriptionLabel.Text = "<Section Description>";
            // 
            // sectionRatingHeaderLabel
            // 
            this.sectionRatingHeaderLabel.AutoSize = true;
            this.sectionRatingHeaderLabel.Location = new System.Drawing.Point(425, 137);
            this.sectionRatingHeaderLabel.Name = "sectionRatingHeaderLabel";
            this.sectionRatingHeaderLabel.Size = new System.Drawing.Size(80, 25);
            this.sectionRatingHeaderLabel.TabIndex = 8;
            this.sectionRatingHeaderLabel.Text = "Rating:";
            // 
            // sectionRatingLabel
            // 
            this.sectionRatingLabel.AutoSize = true;
            this.sectionRatingLabel.Location = new System.Drawing.Point(529, 137);
            this.sectionRatingLabel.Name = "sectionRatingLabel";
            this.sectionRatingLabel.Size = new System.Drawing.Size(98, 25);
            this.sectionRatingLabel.TabIndex = 9;
            this.sectionRatingLabel.Text = "<Rating>";
            // 
            // sectionScoreHeaderLabel
            // 
            this.sectionScoreHeaderLabel.AutoSize = true;
            this.sectionScoreHeaderLabel.Location = new System.Drawing.Point(354, 185);
            this.sectionScoreHeaderLabel.Name = "sectionScoreHeaderLabel";
            this.sectionScoreHeaderLabel.Size = new System.Drawing.Size(151, 25);
            this.sectionScoreHeaderLabel.TabIndex = 10;
            this.sectionScoreHeaderLabel.Text = "Current Score:";
            // 
            // sectionScoreLabel
            // 
            this.sectionScoreLabel.AutoSize = true;
            this.sectionScoreLabel.Location = new System.Drawing.Point(529, 185);
            this.sectionScoreLabel.Name = "sectionScoreLabel";
            this.sectionScoreLabel.Size = new System.Drawing.Size(92, 25);
            this.sectionScoreLabel.TabIndex = 11;
            this.sectionScoreLabel.Text = "<Score>";
            // 
            // sectionTestedByHeaderLabel
            // 
            this.sectionTestedByHeaderLabel.AutoSize = true;
            this.sectionTestedByHeaderLabel.Location = new System.Drawing.Point(343, 234);
            this.sectionTestedByHeaderLabel.Name = "sectionTestedByHeaderLabel";
            this.sectionTestedByHeaderLabel.Size = new System.Drawing.Size(162, 25);
            this.sectionTestedByHeaderLabel.TabIndex = 12;
            this.sectionTestedByHeaderLabel.Text = "Last Tested By:";
            // 
            // sectionLastTestedByLabel
            // 
            this.sectionLastTestedByLabel.AutoSize = true;
            this.sectionLastTestedByLabel.Location = new System.Drawing.Point(529, 234);
            this.sectionLastTestedByLabel.Name = "sectionLastTestedByLabel";
            this.sectionLastTestedByLabel.Size = new System.Drawing.Size(92, 25);
            this.sectionLastTestedByLabel.TabIndex = 13;
            this.sectionLastTestedByLabel.Text = "<Name>";
            // 
            // sectionLastedTestedOnHeaderLabel
            // 
            this.sectionLastedTestedOnHeaderLabel.AutoSize = true;
            this.sectionLastedTestedOnHeaderLabel.Location = new System.Drawing.Point(343, 291);
            this.sectionLastedTestedOnHeaderLabel.Name = "sectionLastedTestedOnHeaderLabel";
            this.sectionLastedTestedOnHeaderLabel.Size = new System.Drawing.Size(165, 25);
            this.sectionLastedTestedOnHeaderLabel.TabIndex = 14;
            this.sectionLastedTestedOnHeaderLabel.Text = "Last Tested On:";
            // 
            // sectionLastedTestedOnLabel
            // 
            this.sectionLastedTestedOnLabel.AutoSize = true;
            this.sectionLastedTestedOnLabel.Location = new System.Drawing.Point(529, 291);
            this.sectionLastedTestedOnLabel.Name = "sectionLastedTestedOnLabel";
            this.sectionLastedTestedOnLabel.Size = new System.Drawing.Size(81, 25);
            this.sectionLastedTestedOnLabel.TabIndex = 15;
            this.sectionLastedTestedOnLabel.Text = "<Date>";
            // 
            // projectViewCharterButton
            // 
            this.projectViewCharterButton.Location = new System.Drawing.Point(386, 351);
            this.projectViewCharterButton.Name = "projectViewCharterButton";
            this.projectViewCharterButton.Size = new System.Drawing.Size(220, 37);
            this.projectViewCharterButton.TabIndex = 16;
            this.projectViewCharterButton.Text = "View Charter";
            this.projectViewCharterButton.UseVisualStyleBackColor = true;
            this.projectViewCharterButton.Click += new System.EventHandler(this.projectViewCharterButton_Click);
            // 
            // ProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.projectViewCharterButton);
            this.Controls.Add(this.sectionLastedTestedOnLabel);
            this.Controls.Add(this.sectionLastedTestedOnHeaderLabel);
            this.Controls.Add(this.sectionLastTestedByLabel);
            this.Controls.Add(this.sectionTestedByHeaderLabel);
            this.Controls.Add(this.sectionScoreLabel);
            this.Controls.Add(this.sectionScoreHeaderLabel);
            this.Controls.Add(this.sectionRatingLabel);
            this.Controls.Add(this.sectionRatingHeaderLabel);
            this.Controls.Add(this.sectionDescriptionLabel);
            this.Controls.Add(sectionListBox);
            this.Controls.Add(this.navProjectPageSprintLabel);
            this.Controls.Add(this.navProjectPageSprintComboBox);
            this.Controls.Add(this.navProjectPageSectionComboBox);
            this.Controls.Add(this.navSectionPageSectionLabel);
            this.Controls.Add(this.navProjectPageProjectLabel);
            this.Controls.Add(this.navProjectPageProjectComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ProjectPage";
            this.ShowIcon = false;
            this.Text = "Charter";
            this.Load += new System.EventHandler(this.ProjectPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox navProjectPageProjectComboBox;
        private System.Windows.Forms.Label navProjectPageProjectLabel;
        private System.Windows.Forms.Label navSectionPageSectionLabel;
        private System.Windows.Forms.ComboBox navProjectPageSectionComboBox;
        private System.Windows.Forms.Label navProjectPageSprintLabel;
        private System.Windows.Forms.Label sectionDescriptionLabel;
        private System.Windows.Forms.Label sectionRatingHeaderLabel;
        private System.Windows.Forms.Label sectionRatingLabel;
        private System.Windows.Forms.Label sectionScoreHeaderLabel;
        private System.Windows.Forms.Label sectionScoreLabel;
        private System.Windows.Forms.Label sectionTestedByHeaderLabel;
        private System.Windows.Forms.Label sectionLastTestedByLabel;
        private System.Windows.Forms.Label sectionLastedTestedOnHeaderLabel;
        private System.Windows.Forms.Label sectionLastedTestedOnLabel;
        private System.Windows.Forms.Button projectViewCharterButton;
        private System.Windows.Forms.ComboBox navProjectPageSprintComboBox;
    }
}

