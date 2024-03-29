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
    public partial class CardDH : UserControl
    {
        public CardDH()
        {
            InitializeComponent();
        }
        #region Properties
        private string _orderUserID;
        private string _soluong;
        private string _date;
        private int _price;
        private string _status;
        private Image _pic;
        [Category("Custom Props")]
        public string OrderUserID { get { return _orderUserID; } set { _orderUserID = value; } }
        [Category("Custom Props")]
        public string Soluong { get { return _soluong; } set { _soluong = value; lblSoluong.Text = value; } }
        [Category("Custom Props")]
        public string Date { get { return _date; } set { _date = value; lbldate.Text = value; } }
        [Category("Custom Props")]
        public string Status { get { return _status; } set { _status = value; lblStatus.Text = value; } }
        [Category("Custom Props")]
        public int Price { get { return _price; } set { _price = value; lblPrice.Text = value.ToString(); } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pictureBox1.Image = value; } }
        #endregion

        private void btnDetails_Click(object sender, EventArgs e)
        {
            OrderDetails details = new OrderDetails(this.OrderUserID);
            details.ShowDialog();
        }
    }
}
