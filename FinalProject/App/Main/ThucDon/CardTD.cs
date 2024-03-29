using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.ThucDon
{
    public partial class CardTD : UserControl
    {
        public CardTD()
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
            this.TotalQuantity = this.TotalQuantity + 1;
            CartTableBLL cartTableBLL = new CartTableBLL();
            cartTableBLL.updateIntoCartData_CartTable_BLL(this.ID, this.TotalQuantity, this.UserID);
        }

        private void SubItem1_Click(object sender, EventArgs e)
        {
            setChoice(CountItem1, SubItem1, false);
            if(TotalQuantity > 0)
            {
                this.TotalQuantity = this.TotalQuantity - 1;
                CartTableBLL cartTableBLL = new CartTableBLL();
                cartTableBLL.updateIntoCartData_CartTable_BLL(this.ID, this.TotalQuantity, this.UserID);
            }
            else if (TotalQuantity == 0)
            {
                CartTableBLL cartTableBLL = new CartTableBLL();
                cartTableBLL.deleteCartItem_CartTable_BLL(this.ID, this.UserID);
            }
        }
        #region Properties

        private string _imgLink;
        private string _id;
        private string _userID;
        private int _totalQuantity;
        private string _title;
        private int _price;
        private Image _pic;

        [Category("Custom Props")]
        public string ImageLink { get { return _imgLink; } set { _imgLink = value; } }
        [Category("Custom Props")]
        public string ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string UserID { get { return _userID; } set { _userID = value; } }
        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; lblName.Text = value; } }
        [Category("Custom Props")]
        public int Price { get { return _price; } set { _price = value; lblPrice.Text = value.ToString(); } }
        [Category("Custom Props")]
        public int TotalQuantity { get { return _totalQuantity; } set { _totalQuantity = value; CountItem1.Text = value.ToString(); } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox9.Image = value; } }
        #endregion

        private void btnTTN_Click(object sender, EventArgs e)
        {
            if(CountItem1.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            else
            {
                
            }
        }
        private void btnTVG_Click(object sender, EventArgs e)
        {
            if (CountItem1.Text == "0")
            {
                MessageBox.Show("Vui lòng nhập số lượng");
                return;
            }
            else
            {
                CartTableBLL newCartTableBLL = new CartTableBLL();
                newCartTableBLL.insertIntoCartData_CartTable_BLL(this.ID, this.ImageLink, this.Title, this.Price, int.Parse(this.CountItem1.Text), this.UserID);
            }
        }
    }
}
