using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharterUi
{
    public partial class ProjectPage : Form
    {
        public ProjectPage()
        {
            InitializeComponent();
        }
        private void projectViewCharterButton_Click(object sender, EventArgs e)
        {
            var viewCharterPage = new ViewCharterPage();
            viewCharterPage.ShowDialog();
        }

        private void ProjectPage_Load(object sender, EventArgs e)
        {
            navProjectPageProjectComboBox.Text = HomePage.projectSelected;
        }

        private void navProjectPageProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (navProjectPageProjectComboBox.Text == "N/A")
            {
                this.Close();
            }
        }

        private void navProjectPageSectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
