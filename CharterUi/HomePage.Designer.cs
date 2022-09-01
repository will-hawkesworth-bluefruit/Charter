namespace CharterUi
{
    partial class HomePage
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
            this.navHomePageSprintLabel = new System.Windows.Forms.Label();
            this.navHomePageSprintComboBox = new System.Windows.Forms.ComboBox();
            this.navHomePageSectionComboBox = new System.Windows.Forms.ComboBox();
            this.navHomePageSectionLabel = new System.Windows.Forms.Label();
            this.navHomePageProjectLabel = new System.Windows.Forms.Label();
            this.navHomePageProjectComboBox = new System.Windows.Forms.ComboBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navHomePageSprintLabel
            // 
            this.navHomePageSprintLabel.AutoSize = true;
            this.navHomePageSprintLabel.Location = new System.Drawing.Point(612, 15);
            this.navHomePageSprintLabel.Name = "navHomePageSprintLabel";
            this.navHomePageSprintLabel.Size = new System.Drawing.Size(74, 25);
            this.navHomePageSprintLabel.TabIndex = 11;
            this.navHomePageSprintLabel.Text = "Sprint:";
            // 
            // navHomePageSprintComboBox
            // 
            this.navHomePageSprintComboBox.Enabled = false;
            this.navHomePageSprintComboBox.FormattingEnabled = true;
            this.navHomePageSprintComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "N/A"});
            this.navHomePageSprintComboBox.Location = new System.Drawing.Point(692, 12);
            this.navHomePageSprintComboBox.Name = "navHomePageSprintComboBox";
            this.navHomePageSprintComboBox.Size = new System.Drawing.Size(54, 33);
            this.navHomePageSprintComboBox.TabIndex = 10;
            this.navHomePageSprintComboBox.Text = "N/A";
            // 
            // navHomePageSectionComboBox
            // 
            this.navHomePageSectionComboBox.Enabled = false;
            this.navHomePageSectionComboBox.FormattingEnabled = true;
            this.navHomePageSectionComboBox.Items.AddRange(new object[] {
            "Home",
            "Roadmap",
            "Features",
            "Kanban",
            "Testing",
            "Reports",
            "Administration",
            "Diagnostics",
            "N/A"});
            this.navHomePageSectionComboBox.Location = new System.Drawing.Point(401, 12);
            this.navHomePageSectionComboBox.Name = "navHomePageSectionComboBox";
            this.navHomePageSectionComboBox.Size = new System.Drawing.Size(205, 33);
            this.navHomePageSectionComboBox.TabIndex = 9;
            this.navHomePageSectionComboBox.Text = "N/A";
            // 
            // navHomePageSectionLabel
            // 
            this.navHomePageSectionLabel.AutoSize = true;
            this.navHomePageSectionLabel.Location = new System.Drawing.Point(305, 15);
            this.navHomePageSectionLabel.Name = "navHomePageSectionLabel";
            this.navHomePageSectionLabel.Size = new System.Drawing.Size(90, 25);
            this.navHomePageSectionLabel.TabIndex = 8;
            this.navHomePageSectionLabel.Text = "Section:";
            // 
            // navHomePageProjectLabel
            // 
            this.navHomePageProjectLabel.AutoSize = true;
            this.navHomePageProjectLabel.Location = new System.Drawing.Point(3, 15);
            this.navHomePageProjectLabel.Name = "navHomePageProjectLabel";
            this.navHomePageProjectLabel.Size = new System.Drawing.Size(85, 25);
            this.navHomePageProjectLabel.TabIndex = 7;
            this.navHomePageProjectLabel.Text = "Project:";
            // 
            // navHomePageProjectComboBox
            // 
            this.navHomePageProjectComboBox.FormattingEnabled = true;
            this.navHomePageProjectComboBox.Items.AddRange(new object[] {
            "Mission Control",
            "N/A"});
            this.navHomePageProjectComboBox.Location = new System.Drawing.Point(94, 12);
            this.navHomePageProjectComboBox.Name = "navHomePageProjectComboBox";
            this.navHomePageProjectComboBox.Size = new System.Drawing.Size(205, 33);
            this.navHomePageProjectComboBox.TabIndex = 6;
            this.navHomePageProjectComboBox.Text = "N/A";
            this.navHomePageProjectComboBox.SelectedIndexChanged += new System.EventHandler(this.navHomePageProjectComboBox_SelectedIndexChanged);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(159, 338);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(482, 33);
            this.instructionLabel.TabIndex = 12;
            this.instructionLabel.Text = "Please Select a Project To Continue";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(274, 203);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(274, 33);
            this.welcomeLabel.TabIndex = 13;
            this.welcomeLabel.Text = "Welcome to Charter";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.navHomePageSprintLabel);
            this.Controls.Add(this.navHomePageSprintComboBox);
            this.Controls.Add(this.navHomePageSectionComboBox);
            this.Controls.Add(this.navHomePageSectionLabel);
            this.Controls.Add(this.navHomePageProjectLabel);
            this.Controls.Add(this.navHomePageProjectComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.ShowIcon = false;
            this.Text = "Charter";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label navHomePageSprintLabel;
        private System.Windows.Forms.ComboBox navHomePageSprintComboBox;
        private System.Windows.Forms.ComboBox navHomePageSectionComboBox;
        private System.Windows.Forms.Label navHomePageSectionLabel;
        private System.Windows.Forms.Label navHomePageProjectLabel;
        private System.Windows.Forms.ComboBox navHomePageProjectComboBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label welcomeLabel;
    }
}