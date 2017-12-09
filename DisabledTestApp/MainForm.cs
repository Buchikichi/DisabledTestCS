using System;
using System.Windows.Forms;

namespace DisabledTestApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            TopPanel.Enabled = !TopPanel.Enabled;
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            SecondPanel.Enabled = !SecondPanel.Enabled;
        }

        private void ThirdButton_Click(object sender, EventArgs e)
        {
            ThirdPanel.Enabled = !ThirdPanel.Enabled;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
