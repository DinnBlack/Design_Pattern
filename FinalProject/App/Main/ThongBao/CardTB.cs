using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Main.ThongBao
{
    public partial class CardTB : UserControl
    {
        TBDetail frm = new TBDetail();
        public CardTB()
        {
            InitializeComponent();
        }

        private void lblChitiet_Click(object sender, EventArgs e)
        {
            frm.ID = this.ID;
            frm.Title = this.Title;
            frm.Date = this.Date;
            frm.ShowDialog();
        }
        #region Properties

        private string _id;
        private string _title;
        private Image _pic;
        private string _date;

        [Category("Custom Props")]
        public string ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; lblTB.Text = value; } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; picNotification.Image = value; } }
        [Category("Custom Props")]
        public string Date { get { return _date; } set { _date = value; label2.Text = value; } }
        #endregion
    }
}
