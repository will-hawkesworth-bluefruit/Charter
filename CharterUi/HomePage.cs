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

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void loadProjectButton_Click(object sender, EventArgs e)
        {
            SectionPage sectionPage = new SectionPage();
            sectionPage.Show();
        }
    }
}
