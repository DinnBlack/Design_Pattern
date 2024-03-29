using FinalProject.DAL;
using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BLL
{
    internal class AdminNotificationBLL
    {
        public DataTable getAllNotification()
        {
            NotificationDAL ehe = new NotificationDAL();
            return ehe.getAllNotification_DAL();
        }
        public void addNotification(Notification item, String des,String focus)
        {
            NotificationDAL ehe = new NotificationDAL();
            ehe.addNotification_DAL(item, des,focus);
        }
        public DataTable searchNotification(String key)
        {
            NotificationDAL ehe = new NotificationDAL();
            return ehe.searchNotification_DAL(key);
        }
        public void deleteNotification(String id)
        {
            NotificationDAL ehe = new NotificationDAL();
            ehe.deleteNotification_DAL(id);
        }
    }
}
