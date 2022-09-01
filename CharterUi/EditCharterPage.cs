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
    public partial class EditCharterPage : Form
    {
        public EditCharterPage()
        {
            InitializeComponent();
        }
        private void editCharterSaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
