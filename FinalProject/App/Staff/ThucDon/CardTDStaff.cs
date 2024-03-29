using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Staff.ThucDon
{
    public partial class CardTDStaff : UserControl
    {
        public CardTDStaff()
        {
            InitializeComponent();
        }

        public void setChoice(Krypton.Toolkit.KryptonLabel lbl, Krypton.Toolkit.KryptonButton btn, Boolean flag)
        {
            int n = Int32.Parse(lbl.Text);
            if (flag)
            {
                lbl.Text = (n + 1).ToString();
            }
            else
            {
                if (n > 0)
                {
                    lbl.Text = (n - 1).ToString();
                }
            }
        }
        private void PlusItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, PlusItem1, true);
        }

        private void SubItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, SubItem1, false);
        }
        #region Properties

        private string _title;
        private int _price;
        private Image _pic;

        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; lblName.Text = value; } }
        [Category("Custom Props")]
        public int Price { get { return _price; } set { _price = value; lblPrice.Text = value.ToString(); } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox9.Image = value; } }
        #endregion
    }
}
