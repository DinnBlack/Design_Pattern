using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Manager
{
    public partial class UCLuong : UserControl
    {
        public UCLuong()
        {
            InitializeComponent();
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(0, 85);
            Point endPoint = new Point(1060, 85);

            LinearGradientBrush lgb =
                new LinearGradientBrush(startPoint, endPoint, Color.FromArgb(255, 250, 247, 229), Color.FromArgb(255, 255, 228, 203));
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, 0, 0, 1060, 170);
        }
    }
}
