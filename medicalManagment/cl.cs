using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class cl : Label
    {
        public cl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.ResizeRedraw |
               ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }
    }
}
