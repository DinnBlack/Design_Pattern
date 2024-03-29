using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAL
{
    internal class RevenueCRUD_DAL: DatabaseSQLServer
    {
        public DataTable getAllRevenue_DAL()
        {
            return getAllRevenue_DA_DAL();
        }
        public DataTable getAllRevenueById_DAL(String key)
        {
            return getAllRevenueById_DA_DAL(key);
        }
        public DataTable getAllRevenueByTime_DAL(String start,String end,String id)
        {
            return getAllRevenueByTime_DA_DAL(start,end,id);
        }
        public DataTable getAllRevenueByIDManager_DAL(String key)
        {
            return getAllRevenueByIdManager_DA_DAL(key);
        }
    }
}
