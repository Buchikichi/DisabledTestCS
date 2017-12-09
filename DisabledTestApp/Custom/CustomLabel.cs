using System.Drawing;
using System.Windows.Forms;

namespace DisabledTestApp.Custom
{
    public partial class CustomLabel : Label
    {
        public CustomLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (Enabled)
            {
                base.OnPaint(pe);
                return;
            }
            var g = pe.Graphics;
            //var size = g.MeasureString(Text, Font);

            //Debug.WriteLine("CustomLabel.OnPaint");
            using (var brush = new SolidBrush(ForeColor))
            {
                g.DrawString(Text, Font, brush, Padding.Left, Padding.Top);
            }
        }
    }
}
