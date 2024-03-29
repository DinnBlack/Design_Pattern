using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.CaiDat
{
    public partial class CardOrderDetails : UserControl
    {
        public CardOrderDetails()
        {
            InitializeComponent();
        }
        #region Properties
        private string _orderUserID;
        private string _dishID;
        private string _name;
        private int _price;
        private Image _pic;
        private int _dishTotal;
        private int _promotionCash;
        [Category("Custom Props")]
        public string OrderUserID { get { return _orderUserID; } set { _orderUserID = value; } }
        [Category("Custom Props")]
        public string DishID { get { return _dishID; } set { _dishID = value; } }
        [Category("Custom Props")]
        public string DishName { get { return _name; } set { _name = value; label5.Text = value; label5.Text = value.ToString(); } }
        [Category("Custom Props")]
        public int Price { get { return _price; } set { _price = value; lblPrice.Text = value.ToString(); } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox1.Image = value; } }
        [Category("Custom Props")]
        public int DishTotal { get { return _dishTotal; } set { _dishTotal = value; lblSoluong.Text = value.ToString(); } }
        [Category("Custom Props")]
        public int PromotionCash { get { return _promotionCash; } set { _promotionCash = value; label3.Text = value.ToString(); } }
        #endregion
    }
}
