using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.KhuyenMai
{
    public partial class CardKMForDisplay : UserControl
    {
        public CardKMForDisplay()
        {
            InitializeComponent();
        }
        #region Properties

        private string _title;
        private string _description;
        private Image _pic;

        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; kryptonLabel36.Text = value; } }
        [Category("Custom Props")]
        public string Description { get { return _description; } set { _description = value; kryptonLabel35.Text = value; } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox12.Image = value; } }
        #endregion
    }
}
