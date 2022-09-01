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
            this.projectSelectComboBox = new System.Windows.Forms.ComboBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.loadProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectSelectComboBox
            // 
            this.projectSelectComboBox.FormattingEnabled = true;
            this.projectSelectComboBox.Items.AddRange(new object[] {
            "Mission Control",
            "N/A"});
            this.projectSelectComboBox.Location = new System.Drawing.Point(107, 194);
            this.projectSelectComboBox.Name = "projectSelectComboBox";
            this.projectSelectComboBox.Size = new System.Drawing.Size(600, 33);
            this.projectSelectComboBox.TabIndex = 6;
            this.projectSelectComboBox.Text = "N/A";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(177, 130);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(482, 33);
            this.instructionLabel.TabIndex = 12;
            this.instructionLabel.Text = "Please Select a Project To Continue";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(253, 66);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(274, 33);
            this.welcomeLabel.TabIndex = 13;
            this.welcomeLabel.Text = "Welcome to Charter";
            // 
            // loadProjectButton
            // 
            this.loadProjectButton.Location = new System.Drawing.Point(301, 245);
            this.loadProjectButton.Name = "loadProjectButton";
            this.loadProjectButton.Size = new System.Drawing.Size(186, 50);
            this.loadProjectButton.TabIndex = 14;
            this.loadProjectButton.Text = "Load";
            this.loadProjectButton.UseVisualStyleBackColor = true;
            this.loadProjectButton.Click += new System.EventHandler(this.loadProjectButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 357);
            this.Controls.Add(this.loadProjectButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.projectSelectComboBox);
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
        private System.Windows.Forms.ComboBox projectSelectComboBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button loadProjectButton;
    }
}