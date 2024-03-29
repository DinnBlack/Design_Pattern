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

namespace FinalProject.App.Admin
{
    public partial class CardKMAdmin : UserControl
    {
        public CardKMAdmin()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PromotionTableBLL ehe = new PromotionTableBLL();
            ehe.deletePromotion(this.PromotionID);
            ButtonClicked?.Invoke(this, e);
        }
        #region Properties
        private string _promotionID;
        private string _title;
        private string _description;
        private string _date;
        private Image _pic;
        private int _percent;
        [Category("Custom Props")]
        public string PromotionID { get { return _promotionID; } set { _promotionID = value; } }
        [Category("Custom Props")]
        public string Date { get { return _date; } set { _date = value; } }
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
    }
}
