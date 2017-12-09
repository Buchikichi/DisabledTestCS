using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabledTestApp.Util
{
    static class ControlExtension
    {
        public static List<Control> GetAllChildren(this Control parent)
        {
            var list = new List<Control>();

            foreach (Control child in parent.Controls)
            {
                var children = child.GetAllChildren();

                list.Add(child);
                list.AddRange(children);
            }
            return list;
        }
    }
}
