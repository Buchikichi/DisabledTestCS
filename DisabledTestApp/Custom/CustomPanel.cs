using DisabledTestApp.Util;
using System.Windows.Forms;

namespace DisabledTestApp.Custom
{
    public partial class CustomPanel : PictureBox
    {
        private bool _enabled;

        public CustomPanel()
        {
            InitializeComponent();
            _enabled = base.Enabled;
        }

        public new bool Enabled
        {
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                foreach (var child in this.GetAllChildren())
                {
                    if (child is Label)
                    {
                        continue;
                    }
                    child.Enabled = value;
                }
            }
        }
    }
}
