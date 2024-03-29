using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.GioHang
{
    public partial class CardGH : UserControl
    {
        public CardGH(FlowLayoutPanel flowLayoutPanel1)
        {
            InitializeComponent();
            this._flowLayoutPanel = flowLayoutPanel1;
        }
        public CardGH()
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
            this.Quantity = this.Quantity + 1;
            CartTableBLL cartTableBLL = new CartTableBLL();
            cartTableBLL.updateIntoCartData_CartTable_BLL(this.ID, this.Quantity, this.UserID);
            ButtonClicked?.Invoke(this, e);
        }

        private void SubItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, SubItem1, false);
            if (this.Quantity > 0)
            {
                this.Quantity = this.Quantity - 1;
                if (Quantity == 0)
                {
                    btnClear_Click(sender, e);
                }
                else
                {
                    CartTableBLL cartTableBLL = new CartTableBLL();
                    cartTableBLL.updateIntoCartData_CartTable_BLL(this.ID, this.Quantity, this.UserID);
                }
                ButtonClicked?.Invoke(this, e);
            }
        }
        #region Properties
        private string _promotionID;
        private FlowLayoutPanel _flowLayoutPanel;
        private string _id;
        private string _title;
        private int _price;
        private Image _pic;
        private int _quantity;
        private string _userID;
        private int _percent;
        [Category("Custom Props")]
        public string PromotionID { get { return _promotionID; } set { _promotionID = value; } }
        [Category("Custom Props")]
        public int Percent { get { return _percent; } set { _percent = value; } }
        [Category("Custom Props")]
        public string UserID { get { return _userID; } set { _userID = value; } }
        [Category("Custom Props")]
        public FlowLayoutPanel FlowLayoutPanel { get { return _flowLayoutPanel; } set { _flowLayoutPanel = value; } }
        [Category("Custom Props")]
        public string ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; lblName.Text = value; } }
        [Category("Custom Props")]
        public int Price { get { return _price; } set { _price = value; lblPrice.Text = value.ToString(); } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox9.Image = value; } }
        [Category("Custom Props")]
        public int Quantity { get { return _quantity; } set { _quantity = value; CountItem1.Text = value.ToString(); } }
        #endregion
        public event EventHandler ButtonClicked;
        private void btnClear_Click(object sender, EventArgs e)
        {
            CartTableBLL cartTableBLL = new CartTableBLL();
            cartTableBLL.deleteCartItem_CartTable_BLL(this.ID, this.UserID);
            ButtonClicked?.Invoke(this, e);
        }
    }
}
