using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostManager
{
    class Utilities
    {
        public static List<T> GetAllControls<T>(Control root) where T : Control
        {
            if (root == null) { throw new ArgumentNullException("root"); }
            List<T> result = new List<T>();
            foreach (Control c in root.Controls)
            {
                if (c.GetType() == typeof(T)) { result.Add((T)c); }
                if (c.HasChildren) { result.AddRange(GetAllControls<T>(c)); }
            }
            return result;
        }
    }
}
