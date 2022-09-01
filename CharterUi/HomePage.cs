using System;
using System.Windows.Forms;

namespace CharterUi
{
    public partial class HomePage : Form
    {
        public static string projectSelected;

        public HomePage()
        {
            InitializeComponent();
        }

        private void navHomePageProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(navHomePageProjectComboBox.Text == "N/A"))
            {
                var projectPage = new ProjectPage();
                projectPage.Location = this.Location;
                projectPage.StartPosition = FormStartPosition.Manual;
                projectPage.FormClosing += delegate { this.Show(); };
                projectSelected = navHomePageProjectComboBox.Text;
                navHomePageProjectComboBox.Text = "N/A";
                projectPage.Show();
                this.Hide();
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
