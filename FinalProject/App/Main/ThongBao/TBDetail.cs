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

namespace FinalProject.App.Main.ThongBao
{
    public partial class TBDetail : Form
    {
        public TBDetail()
        {
            InitializeComponent();
        }
        private void populateNotificationItem_UCTB()
        {
            NotificationTableBLL newNotificationTableBLL = new NotificationTableBLL();

            if (newNotificationTableBLL.populateNotificationDataDetail_NotificationTable_BLL() != null)
            {
                foreach (DataRow row in newNotificationTableBLL.populateNotificationDataDetail_NotificationTable_BLL().Rows)
                {
                    FinalProject.DTO.Notification newItem = new FinalProject.DTO.Notification();

                    newItem.notificationID = row["notificationID"].ToString();
                    newItem.notificationPicture = row["notificationPictureDetail"].ToString();
                    newItem.notificationName = row["notificationDescription"].ToString();
                    newItem.notificationDate = row["notificationFocus"].ToString();

                    if(newItem.notificationID == this.ID)
                    {
                        label1.Text = this.Title;
                        label2.Text = this.Date.Split(' ')[0];
                        var request = WebRequest.Create(newItem.notificationPicture);

                        using (var response = request.GetResponse())
                        using (var stream = response.GetResponseStream())
                        {
                            pictureBox1.Image = Bitmap.FromStream(stream);
                        }
                        label3.Text = newItem.notificationName;
                        label5.Text = newItem.notificationDate;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu NotificationDataDetail");
            }
        }
        #region Properties

        private string _id;
        private string _title;
        private string _date;

        [Category("Custom Props")]
        public string ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; } }
        [Category("Custom Props")]
        public string Date { get { return _date; } set { _date = value; } }
        #endregion

        private void TBDetail_Load(object sender, EventArgs e)
        {
            populateNotificationItem_UCTB();
        }
    }
}
