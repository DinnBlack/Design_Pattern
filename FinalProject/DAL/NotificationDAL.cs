using FinalProject.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class NotificationDAL: DatabaseSQLServer

    {
        public DataTable getAllNotification_DAL()
        {
            return getAllNotification_DA_DAL();
        }
        public DataTable getNotificationItem_DAL()
        {
            return getNotificationItem_DA_DAL();
        }
        public void addNotification_DAL(Notification item, String des,String focus)
        {
            addNotification_DA_DAL(item, des,focus);
        }
        public DataTable searchNotification_DAL(String key)
        {
            return searchNotification_DA_DAL(key);
        }
        public void deleteNotification_DAL(String id)
        {
            deleteNotification_DA_DAL(id);
        }
    }
}
