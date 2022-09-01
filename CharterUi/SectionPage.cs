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
    public partial class SectionPage : Form
    {
        public SectionPage()
        {
            InitializeComponent();
        }

        private void sectionViewCharterButton_Click(object sender, EventArgs e)
        {
            var viewCharterPage = new ViewCharterPage();
            viewCharterPage.ShowDialog();
        }

        private void sectionEditCharterButton_Click(object sender, EventArgs e)
        {
            var editCharterPage = new EditCharterPage();
            editCharterPage.ShowDialog();
        }

        private void sectionNewCharterButton_Click(object sender, EventArgs e)
        {
            var newCharterPage = new NewCharterPage();
            newCharterPage.ShowDialog();
        }

        private void SectionPage_Load(object sender, EventArgs e)
        {
            navSectionPageProjectComboBox.Text = HomePage.projectSelected;
        }

    }
}
