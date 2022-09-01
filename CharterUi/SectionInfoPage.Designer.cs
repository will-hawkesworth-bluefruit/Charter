namespace CharterUi
{
    partial class SectionInfoPage
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
            this.closeHelpButton = new System.Windows.Forms.Button();
            this.sectionInfoLabelTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeHelpButton
            // 
            this.closeHelpButton.Location = new System.Drawing.Point(118, 202);
            this.closeHelpButton.Margin = new System.Windows.Forms.Padding(6);
            this.closeHelpButton.Name = "closeHelpButton";
            this.closeHelpButton.Size = new System.Drawing.Size(150, 44);
            this.closeHelpButton.TabIndex = 0;
            this.closeHelpButton.Text = "Close";
            this.closeHelpButton.UseVisualStyleBackColor = true;
            this.closeHelpButton.Click += new System.EventHandler(this.closeHelpButton_Click);
            // 
            // sectionInfoLabelTemp
            // 
            this.sectionInfoLabelTemp.AutoSize = true;
            this.sectionInfoLabelTemp.Location = new System.Drawing.Point(92, 91);
            this.sectionInfoLabelTemp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sectionInfoLabelTemp.Name = "sectionInfoLabelTemp";
            this.sectionInfoLabelTemp.Size = new System.Drawing.Size(216, 25);
            this.sectionInfoLabelTemp.TabIndex = 1;
            this.sectionInfoLabelTemp.Text = "SectionInfoGoesHere";
            // 
            // SectionInfoPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.sectionInfoLabelTemp);
            this.Controls.Add(this.closeHelpButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "SectionInfoPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Charter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeHelpButton;
        private System.Windows.Forms.Label sectionInfoLabelTemp;
    }
}