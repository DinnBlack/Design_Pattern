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

namespace FinalProject.App.Main
{
    public partial class CardKM : UserControl
    {
        public CardKM()
        {
            InitializeComponent();
        }
        #region Properties
        private string _promotionID;
        private string _userID;
        private string _dishID;
        private string _title;
        private string _description;
        private Image _pic;
        private int _percent;
        [Category("Custom Props")]
        public string PromotionID { get { return _promotionID; } set { _promotionID = value; } }
        [Category("Custom Props")]
        public string UserID { get { return _title; } set { _title = value; } }
        [Category("Custom Props")]
        public string DishID { get { return _title; } set { _title = value; } }
        [Category("Custom Props")]
        public int Percent { get { return _percent; } set { _percent = value; } }
        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; kryptonLabel36.Text = value; } }
        [Category("Custom Props")]
        public string Description { get { return _description; } set { _description = value; kryptonLabel35.Text = value; } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox12.Image = value; } }
        #endregion
        public event EventHandler ButtonClicked;
        private void ButtonKM1_Click(object sender, EventArgs e)
        {
            CartTableBLL newCartTableBLL = new CartTableBLL();
            newCartTableBLL.updateCartDataPromotion_CartTable_BLL(this.PromotionID, this.Percent.ToString(), this.UserID);
            MessageBox.Show("Đã áp dụng khuyến mãi vừa chọn");
            ButtonClicked?.Invoke(this, e);
        }
    }
}
