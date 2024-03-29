using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.DTO;
using FinalProject.DAL;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace FinalProject.BLL
{
    internal class NotificationTableBLL
    {
        NotificationDAL notificationDAL = new NotificationDAL();
        public DataTable populateNotificationData_NotificationTable_BLL()
        {
            if (notificationDAL.getAllNotification_DAL().Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return notificationDAL.getAllNotification_DAL();
            }
        }
        public DataTable populateNotificationDataDetail_NotificationTable_BLL()
        {
            if (notificationDAL.getNotificationItem_DAL().Rows.Count <= 0)
            {
                return null;
            }
            else
            {
                return notificationDAL.getNotificationItem_DAL();
            }
        }
    }
}
