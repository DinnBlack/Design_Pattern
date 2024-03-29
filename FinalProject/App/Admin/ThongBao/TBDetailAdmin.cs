using FinalProject.DAL;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.App.Admin.ThongBao
{
    public partial class TBDetailAdmin : Form
    {
        public TBDetailAdmin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Notification item = new Notification();
            NotificationDAL ehe = new NotificationDAL();
            item.notificationPicture = tbPoster.Text;
            item.notificationName = txtTD.Text;
            item.notificationDate = timePick.Value.ToString();
            String focus = tbFocus.Text;
            String des = txtND.Text;
            ehe.addNotification_DAL(item, des,focus);
        }
    }
}
