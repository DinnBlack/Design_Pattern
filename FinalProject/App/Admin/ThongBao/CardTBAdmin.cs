using FinalProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Admin.ThongBao
{
    public partial class CardTBAdmin : UserControl
    {
        Form frm = new TBDetailAdmin();
        public event EventHandler ButtonClicked;
        public CardTBAdmin()
        {
            InitializeComponent();
        }

        #region Properties

        private string _id;
        private string _title;
        private Image _pic;
        [Category("Custom Props")]
        public string ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; lblTB.Text = value; } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; picTB.Image = value; } }
        [Category("Custom Props")]
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdminNotificationBLL ehe = new AdminNotificationBLL();
            ehe.deleteNotification(this.ID);
            ButtonClicked?.Invoke(this, e);
        }
    }
}
